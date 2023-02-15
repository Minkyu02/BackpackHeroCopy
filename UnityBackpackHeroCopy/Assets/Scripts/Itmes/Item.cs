using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Item : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    private RectTransform itemRect = null;
    private bool isSelect = false;
    private bool isInit = false;
    public GameObject mostNearInventory = null;
    private GameObject prevNearInventory = null;
    private bool InventoryCheck = false;
    private InventoryBg inventoryBg = null;
    private GameObject itemBackImgPrefebs = null;
    protected GameObject[] itemSize = new GameObject[9];
    protected List<GameObject> itemActive = new List<GameObject>();
    Vector3 point = Vector3.zero;


    // Start is called before the first frame update
    protected virtual void Start()
    {
        itemRect = GetComponent<RectTransform>();
        itemBackImgPrefebs = Resources.Load<GameObject>("Prefebs/Item/ItemBackImg");
        for (int i = 0; i < itemSize.Length; i++)
        {
            itemSize[i] = Instantiate(itemBackImgPrefebs);
            itemSize[i].transform.SetParent(gameObject.transform.GetChild(0), false);
            itemSize[i].GetComponent<Image>().enabled = false;
        }
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        RotateItem();
        MousePoint();
    }

    private void RotateItem()
    {
        if (Input.GetMouseButtonDown(1) && isSelect)
        {
            itemRect.rotation = itemRect.rotation * Quaternion.Euler(0, 0, 90);
        }
    }
    private void MousePoint()
    {
        point = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, -Camera.main.transform.position.z));
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isSelect = true;
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        isSelect = false;
        if (isInit)
        {
            transform.position = mostNearInventory.transform.position;
            gameObject.transform.GetChild(2).GetComponent<Image>().enabled = false;
        }

    }
    public void OnDrag(PointerEventData eventData)
    {
        if (isSelect)
        {
            DistancePockets();
            gameObject.transform.position = point;
        }
    }

    private void DistancePockets()
    {
        for (int i = 0; i < InventoryManager.Instance.backpackArray.Length; i++)
        {
            if (InventoryManager.Instance.backpackArray[i].GetComponent<InventoryBg>().isActive)
            {
                if (Vector2.Distance(transform.position, InventoryManager.Instance.backpackArray[i].transform.position) <= 0.5)
                {
                    inventoryBg = InventoryManager.Instance.backpackArray[i].GetComponent<InventoryBg>();
                    mostNearInventory = InventoryManager.Instance.backpackArray[i];
                    if (mostNearInventory.Equals(prevNearInventory))
                    {
                        //Do Nothing
                    }
                    else
                    {
                        for (int j = 0; j < itemActive.Count; j++) {

                        }
                        // Debug.Log("false");
                        // Debug.Log($"전꺼 2차원 배열 : {mostNearInventory.GetComponent<InventoryBg>().index_X}, {mostNearInventory.GetComponent<InventoryBg>().index_Y}");
                    }
                        prevNearInventory = mostNearInventory;
                        gameObject.transform.GetChild(2).GetComponent<Image>().enabled = true;
                        gameObject.transform.GetChild(2).position = mostNearInventory.transform.position;
                    // Debug.Log($"2차원 배열 : {inventoryBg.index_X}, {inventoryBg.index_Y}");
                    // Debug.Log($"2차원 배열 : {InventoryManager.Instance.backPack.GetIndex2D(i)}");
                    isInit = true;
                }
            }
            else
            {
                if (Vector2.Distance(transform.position, InventoryManager.Instance.backpackArray[i].transform.position) <= 0.5)
                {
                    gameObject.transform.GetChild(2).GetComponent<Image>().enabled = false;
                    gameObject.transform.GetChild(2).position = transform.position;
                    isInit = false;
                }
            }
        }
    }

    // 생각해볼것 

}
