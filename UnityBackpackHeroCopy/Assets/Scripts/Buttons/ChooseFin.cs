using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseFin : MonoBehaviour
{
    public GameObject items = null;
    // Start is called before the first frame update
    void Start()
    {
        ButtonManager.Instance.btn_ChooseFin = this.gameObject;
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Btn_DestoryItem()
    {
        for (int i = 0; i < items.transform.childCount; i++)
        {
            if (items.transform.GetChild(i).GetComponent<Item>().isValue)
            {

            }
            else
            {
                Destroy(items.transform.GetChild(i).gameObject);
            }
        }
        gameObject.SetActive(false);
    }
}
