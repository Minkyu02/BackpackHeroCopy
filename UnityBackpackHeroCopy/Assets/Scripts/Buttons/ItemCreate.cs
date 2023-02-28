using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCreate : MonoBehaviour
{
    private List<GameObject> itemPrefebs = new List<GameObject>();
    public Transform parentsTrans = null;
    private GameObject item = null;
    // Start is called before the first frame update
    void Start()
    {
        ButtonManager.Instance.btn_ItemCreate = this.gameObject;
        for (int i = 0; i < Resources.LoadAll<GameObject>("Prefebs/Item/Items").Length; i++)
        {
            itemPrefebs.Add(Resources.LoadAll<GameObject>("Prefebs/Item/Items")[i]);
        }
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void Btn_CreateItem()
    {
        GameManager.Instance.RootMode();

        for (int i = 0; i < Random.Range(3, 7); i++)
        {
            item = Instantiate(itemPrefebs[Random.Range(0, Resources.LoadAll<GameObject>("Prefebs/Item/Items").Length)]);
            item.transform.SetParent(parentsTrans, false);
            item.transform.localPosition = new Vector2(Random.Range(-800f, 700f), Random.Range(-300f, -500f));
        }
        gameObject.SetActive(false);
        PlayerManager.Instance.isWin = false;
        ButtonManager.Instance.btn_ChooseFin.SetActive(true);

    }
}
