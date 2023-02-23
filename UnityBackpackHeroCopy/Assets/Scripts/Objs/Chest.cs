using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Chest : MonoBehaviour, IPointerClickHandler
{
    private List<GameObject> itemPrefebs = new List<GameObject>();
    public Transform parentsTrans = null;
    private GameObject item = null;
    private bool isOpen = false;
    public Sprite openChestImg = null;
    public Sprite unopenChestImg = null;
    private Image ChestImg = null;
    // Start is called before the first frame update
    void Awake()
    {
        for (int i = 0; i < Resources.LoadAll<GameObject>("Prefebs/Item/Items").Length; i++)
        {
            itemPrefebs.Add(Resources.LoadAll<GameObject>("Prefebs/Item/Items")[i]);
        }
        ChestImg = transform.GetChild(0).GetComponent<Image>();
    }

    private void OnEnable()
    {
        isOpen = false;
        ChestImg.sprite = unopenChestImg;
    }
    // Update is called once per frame
    void Update()
    {

    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (!isOpen)
        {
            GameManager.Instance.RootMode();
            isOpen = true;
            ChestImg.sprite = openChestImg;
            Debug.Log("?");
            for (int i = 0; i < Random.Range(3, 7); i++)
            {
                item = Instantiate(itemPrefebs[Random.Range(0, Resources.LoadAll<GameObject>("Prefebs/Item/Items").Length)]);
                item.transform.SetParent(parentsTrans, false);
                item.transform.localPosition = new Vector2(Random.Range(-800f, 700f), Random.Range(-300f, -500f));
            }
            ButtonManager.Instance.btn_ChooseFin.SetActive(true);
        }
    }
}
