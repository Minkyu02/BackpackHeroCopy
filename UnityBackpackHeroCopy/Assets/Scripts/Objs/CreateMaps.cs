using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMaps : MonoBehaviour
{
    private List<GameObject> eventPrefebs = new List<GameObject>();
    public GameObject eventParents = null;
    private GameObject nextDoorPrefebs = null;
    // Start is called before the first frame update

    void Awake()
    {
        for (int i = 0; i < Resources.LoadAll<GameObject>("Prefebs/Event").Length; i++)
        {
            eventPrefebs.Add(Resources.LoadAll<GameObject>("Prefebs/Event")[i]);
        }

        if (this.name == "Stage1")
        {
            GameManager.Instance.stage1 = this.gameObject;
        }
        else if (this.name == "Stage2")
        {
            GameManager.Instance.stage2 = this.gameObject;
            gameObject.SetActive(false);
        }
    }

    void Start()
    {
        MapCreate();
    }

    void OnDisable()
    {
        if (this.name == "Stage1")
        {
            for (int i = 0; i < eventParents.transform.childCount; i++) {
                Destroy(eventParents.transform.GetChild(i));
            }
        }
    }

    private void MapCreate()
    {
        GameManager.Instance.playMaps = new List<Transform>();

        for (int i = 0; i < transform.childCount; i++)
        {
            GameManager.Instance.playMaps.Add(transform.GetChild(i));
            GameManager.Instance.playMaps[i].GetComponent<Road>().mapIndex = i;
        }

        // 방 맨끝에 문 이벤트 생성
        nextDoorPrefebs = Resources.Load<GameObject>("Prefebs/Door/DoorEvent");
        GameObject nextDoor = Instantiate(nextDoorPrefebs);
        nextDoor.transform.SetParent(eventParents.transform, false);
        nextDoor.transform.position = GameManager.Instance.playMaps[transform.childCount - 1].position;
        nextDoor.GetComponent<Road>().mapIndex = transform.childCount - 1;
        GameManager.Instance.playMaps[transform.childCount - 1].GetComponent<Road>().isHaveEvent = true;

        GameObject chestEvent = Instantiate(eventPrefebs[0]);
        chestEvent.transform.SetParent(eventParents.transform, false);
        chestEvent.transform.position = GameManager.Instance.playMaps[1].position;
        chestEvent.GetComponent<Road>().mapIndex = 1;
        GameManager.Instance.playMaps[1].GetComponent<Road>().isHaveEvent = true;

        // 
        for (int i = 0; i < Resources.LoadAll<GameObject>("Prefebs/Event").Length; i++)
        {
            GameObject playEvent = Instantiate(eventPrefebs[i]);
            playEvent.transform.SetParent(eventParents.transform, false);
            int EventPos = 0;
            while (true)
            {
                EventPos = Random.Range(1, transform.childCount - 1);
                if (!GameManager.Instance.playMaps[EventPos].GetComponent<Road>().isHaveEvent)
                {
                    break;
                }
            }
            playEvent.transform.position = GameManager.Instance.playMaps[EventPos].position;
            playEvent.GetComponent<Road>().mapIndex = EventPos;
            GameManager.Instance.playMaps[EventPos].GetComponent<Road>().isHaveEvent = true;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
