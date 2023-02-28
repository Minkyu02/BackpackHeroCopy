using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

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
                if (isNextRoom)
                {
                    StartCoroutine(Disappear());
                    isNextRoom = false;
                }
            }
            else
            {
                PlayerManager.Instance.playerPos.Translate(Vector3.right * Time.deltaTime * 3f);
            }
        }
    }

    IEnumerator Disappear()
    {
        while (PlayerManager.Instance.playerPos.transform.GetChild(0).GetComponent<Image>().color.a > 0)
        {
            float imagColor = PlayerManager.Instance.playerPos.transform.GetChild(0).GetComponent<Image>().color.a;
            imagColor -= 0.01f;
            PlayerManager.Instance.playerPos.transform.GetChild(0).GetComponent<Image>().color = new Color(1f,1f,1f,imagColor);
            yield return new WaitForSeconds(0.01f);
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        isNextRoom = true;
    }
}
