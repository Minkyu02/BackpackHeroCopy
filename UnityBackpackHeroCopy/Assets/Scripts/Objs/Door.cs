using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Door : MonoBehaviour, IPointerClickHandler
{
    public bool isNextRoom = false;
    // Start is called before the first frame update
    void Start()
    {
        GameManager.Instance.nextStageDoor = gameObject;
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isNextRoom)
        {
            if (PlayerManager.Instance.playerPos.position.x >= transform.position.x)
            {
                isNextRoom = false;
            }
            else
            {
                PlayerManager.Instance.playerPos.Translate(Vector3.right * Time.deltaTime * 3f);
            }
        }
    }


    public void OnPointerClick(PointerEventData eventData)
    {
        isNextRoom = true;
    }
}
