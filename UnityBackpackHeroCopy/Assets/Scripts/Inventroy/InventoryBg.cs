using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class InventoryBg : MonoBehaviour, IPointerDownHandler
{
    public bool isActive = false;
    public bool isChoose = false;
    public bool isHave = false;
    public bool checkActive = false;
    private Image image = null;
    public int index = 0;
    public int index_Y = 0;
    public int index_X = 0;
    public RectTransform rect = null;
    private Transform parentsTransform = null;
    RectTransform backPackImg = null;
    RectTransform backPackBgImg = null;
    // Start is called before the first frame update
    void Start()
    {
        rect = GetComponent<RectTransform>();
        image = GetComponent<Image>();
        parentsTransform = transform.parent.parent.GetChild(2);
        backPackImg = gameObject.transform.parent.parent.GetChild(0).GetComponent<RectTransform>();
        backPackBgImg = gameObject.transform.parent.parent.GetChild(1).GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (isChoose && !isActive && transform.parent.parent.GetComponent<InventoryUpgrade>().isLevelup)
        {
            GameManager.Instance.upgradeCount++;
            isChoose = false;
            ContractInventory();
            transform.GetChild(1).gameObject.SetActive(false);
        }
        else if (!isActive && !isChoose && GameManager.Instance.upgradeCount > 0)
        {
            GameManager.Instance.upgradeCount--;
            ExpendInventory();
            isChoose = true;
        }
    }

    public void OnActive()
    {
        if (isActive)
        {
            transform.GetChild(0).gameObject.SetActive(true);
            transform.GetChild(1).gameObject.SetActive(false);
            transform.SetParent(parentsTransform, false);
        }
        else
        {
            transform.GetChild(0).gameObject.SetActive(false);
            transform.GetChild(1).gameObject.SetActive(false);
        }
    }

    public void OnSelectAble()
    {
        if (!isActive)
        {
            transform.GetChild(0).gameObject.SetActive(false);
            transform.GetChild(1).gameObject.SetActive(true);
        }
    }
    public void OnSelect()
    {
        if (isChoose)
        {
            transform.GetChild(0).gameObject.SetActive(true);
            transform.GetChild(1).gameObject.SetActive(true);
        }
    }

    public void ContractInventory()
    {
        bool isExpand = false;
        switch (index_X)
        {
            case 0:
                for (int y = 0; y < InventoryManager.Instance.backpack2Array.GetUpperBound(0); y++)
                {
                    if (InventoryManager.Instance.backpack2Array[y, index_X].GetComponent<InventoryBg>().isChoose || InventoryManager.Instance.backpack2Array[y, index_X].GetComponent<InventoryBg>().isActive)
                    {
                        isExpand = true;
                        break;
                    }
                }
                if (InventoryManager.Instance.expendLeft == 2 && !isExpand)
                {
                    backPackImg.sizeDelta = new Vector2(backPackImg.sizeDelta.x - rect.sizeDelta.x, backPackImg.sizeDelta.y);
                    backPackBgImg.sizeDelta = new Vector2(backPackBgImg.sizeDelta.x - rect.sizeDelta.x, backPackBgImg.sizeDelta.y);
                    backPackImg.anchoredPosition = new Vector2(backPackImg.anchoredPosition.x + 50, backPackImg.anchoredPosition.y);
                    backPackBgImg.anchoredPosition = new Vector2(backPackBgImg.anchoredPosition.x + 50, backPackBgImg.anchoredPosition.y);
                    InventoryManager.Instance.expendLeft--;
                    break;
                }
                break;
            case 1:
                for (int y = 0; y < InventoryManager.Instance.backpack2Array.GetUpperBound(0); y++)
                {
                    if (InventoryManager.Instance.backpack2Array[y, index_X].GetComponent<InventoryBg>().isChoose || InventoryManager.Instance.backpack2Array[y, index_X].GetComponent<InventoryBg>().isActive)
                    {
                        isExpand = true;
                        break;
                    }
                }
                if (InventoryManager.Instance.expendLeft == 1 && !isExpand)
                {
                    backPackImg.sizeDelta = new Vector2(backPackImg.sizeDelta.x - rect.sizeDelta.x, backPackImg.sizeDelta.y);
                    backPackBgImg.sizeDelta = new Vector2(backPackBgImg.sizeDelta.x - rect.sizeDelta.x, backPackBgImg.sizeDelta.y);
                    backPackImg.anchoredPosition = new Vector2(backPackImg.anchoredPosition.x + 50, backPackImg.anchoredPosition.y);
                    backPackBgImg.anchoredPosition = new Vector2(backPackBgImg.anchoredPosition.x + 50, backPackBgImg.anchoredPosition.y);
                    InventoryManager.Instance.expendLeft--;
                }
                break;
            case 5:
                for (int y = 0; y < InventoryManager.Instance.backpack2Array.GetUpperBound(0); y++)
                {
                    if (InventoryManager.Instance.backpack2Array[y, index_X].GetComponent<InventoryBg>().isChoose || InventoryManager.Instance.backpack2Array[y, index_X].GetComponent<InventoryBg>().isActive)
                    {
                        isExpand = true;
                        break;
                    }
                }
                if (InventoryManager.Instance.expendRight == 1 && !isExpand)
                {
                    backPackImg.sizeDelta = new Vector2(backPackImg.sizeDelta.x - rect.sizeDelta.x, backPackImg.sizeDelta.y);
                    backPackBgImg.sizeDelta = new Vector2(backPackBgImg.sizeDelta.x - rect.sizeDelta.x, backPackBgImg.sizeDelta.y);
                    backPackImg.anchoredPosition = new Vector2(backPackImg.anchoredPosition.x - 50, backPackImg.anchoredPosition.y);
                    backPackBgImg.anchoredPosition = new Vector2(backPackBgImg.anchoredPosition.x - 50, backPackBgImg.anchoredPosition.y);
                    InventoryManager.Instance.expendRight--;
                }
                break;
            case 6:
                for (int y = 0; y < InventoryManager.Instance.backpack2Array.GetUpperBound(0); y++)
                {
                    if (InventoryManager.Instance.backpack2Array[y, index_X].GetComponent<InventoryBg>().isChoose || InventoryManager.Instance.backpack2Array[y, index_X].GetComponent<InventoryBg>().isActive)
                    {
                        isExpand = true;
                        break;
                    }
                }
                if (InventoryManager.Instance.expendRight == 2 && !isExpand)
                {
                    backPackImg.sizeDelta = new Vector2(backPackImg.sizeDelta.x - rect.sizeDelta.x, backPackImg.sizeDelta.y);
                    backPackBgImg.sizeDelta = new Vector2(backPackBgImg.sizeDelta.x - rect.sizeDelta.x, backPackBgImg.sizeDelta.y);
                    backPackImg.anchoredPosition = new Vector2(backPackImg.anchoredPosition.x - 50, backPackImg.anchoredPosition.y);
                    backPackBgImg.anchoredPosition = new Vector2(backPackBgImg.anchoredPosition.x - 50, backPackBgImg.anchoredPosition.y);
                    InventoryManager.Instance.expendRight--;
                }
                break;
        }
        switch (index_Y)
        {
            case 0:
                for (int x = 0; x < InventoryManager.Instance.backpack2Array.GetUpperBound(1); x++)
                {
                    if (InventoryManager.Instance.backpack2Array[index_Y, x].GetComponent<InventoryBg>().isChoose || InventoryManager.Instance.backpack2Array[index_Y, index_X].GetComponent<InventoryBg>().isActive)
                    {
                        isExpand = true;
                        break;
                    }
                }
                if (InventoryManager.Instance.expendUp == 1 && !isExpand)
                {
                    backPackImg.sizeDelta = new Vector2(backPackImg.sizeDelta.x, backPackImg.sizeDelta.y - rect.sizeDelta.y);
                    backPackBgImg.sizeDelta = new Vector2(backPackBgImg.sizeDelta.x, backPackBgImg.sizeDelta.y - rect.sizeDelta.y);
                    backPackImg.anchoredPosition = new Vector3(backPackImg.anchoredPosition.x, backPackImg.anchoredPosition.y - 50);
                    backPackBgImg.anchoredPosition = new Vector3(backPackBgImg.anchoredPosition.x, backPackBgImg.anchoredPosition.y - 50);
                    InventoryManager.Instance.expendUp--;
                }
                break;
            case 4:
                for (int x = 0; x < InventoryManager.Instance.backpack2Array.GetUpperBound(1); x++)
                {
                    if (InventoryManager.Instance.backpack2Array[index_Y, x].GetComponent<InventoryBg>().isChoose || InventoryManager.Instance.backpack2Array[index_Y, index_X].GetComponent<InventoryBg>().isActive)
                    {
                        isExpand = true;
                        break;
                    }
                }


                if (InventoryManager.Instance.expendDown == 1 && !isExpand)
                {
                    backPackImg.sizeDelta = new Vector2(backPackImg.sizeDelta.x, backPackImg.sizeDelta.y - rect.sizeDelta.y);
                    backPackBgImg.sizeDelta = new Vector2(backPackBgImg.sizeDelta.x, backPackBgImg.sizeDelta.y - rect.sizeDelta.y);
                    backPackImg.anchoredPosition = new Vector3(backPackImg.anchoredPosition.x, backPackImg.anchoredPosition.y + 50);
                    backPackBgImg.anchoredPosition = new Vector3(backPackBgImg.anchoredPosition.x, backPackBgImg.anchoredPosition.y + 50);
                    InventoryManager.Instance.expendDown--;
                }
                break;
        }
    }


    public void ExpendInventory()
    {
        switch (index_X)
        {
            case 0:
                if (InventoryManager.Instance.expendLeft == 1)
                {
                    backPackImg.sizeDelta = new Vector2(backPackImg.sizeDelta.x + rect.sizeDelta.x, backPackImg.sizeDelta.y);
                    backPackBgImg.sizeDelta = new Vector2(backPackBgImg.sizeDelta.x + rect.sizeDelta.x, backPackBgImg.sizeDelta.y);
                    backPackImg.anchoredPosition = new Vector2(backPackImg.anchoredPosition.x - 50, backPackImg.anchoredPosition.y);
                    backPackBgImg.anchoredPosition = new Vector2(backPackBgImg.anchoredPosition.x - 50, backPackBgImg.anchoredPosition.y);
                    InventoryManager.Instance.expendLeft++;
                }
                break;
            case 1:
                if (InventoryManager.Instance.expendLeft == 0)
                {
                    backPackImg.sizeDelta = new Vector2(backPackImg.sizeDelta.x + rect.sizeDelta.x, backPackImg.sizeDelta.y);
                    backPackBgImg.sizeDelta = new Vector2(backPackBgImg.sizeDelta.x + rect.sizeDelta.x, backPackBgImg.sizeDelta.y);
                    backPackImg.anchoredPosition = new Vector2(backPackImg.anchoredPosition.x - 50, backPackImg.anchoredPosition.y);
                    backPackBgImg.anchoredPosition = new Vector2(backPackBgImg.anchoredPosition.x - 50, backPackBgImg.anchoredPosition.y);
                    InventoryManager.Instance.expendLeft++;
                }
                break;
            case 5:
                if (InventoryManager.Instance.expendRight == 0)
                {
                    backPackImg.sizeDelta = new Vector2(backPackImg.sizeDelta.x + rect.sizeDelta.x, backPackImg.sizeDelta.y);
                    backPackBgImg.sizeDelta = new Vector2(backPackBgImg.sizeDelta.x + rect.sizeDelta.x, backPackBgImg.sizeDelta.y);
                    backPackImg.anchoredPosition = new Vector2(backPackImg.anchoredPosition.x + 50, backPackImg.anchoredPosition.y);
                    backPackBgImg.anchoredPosition = new Vector2(backPackBgImg.anchoredPosition.x + 50, backPackBgImg.anchoredPosition.y);
                    InventoryManager.Instance.expendRight++;
                }
                break;
            case 6:
                if (InventoryManager.Instance.expendRight == 1)
                {
                    backPackImg.sizeDelta = new Vector2(backPackImg.sizeDelta.x + rect.sizeDelta.x, backPackImg.sizeDelta.y);
                    backPackBgImg.sizeDelta = new Vector2(backPackBgImg.sizeDelta.x + rect.sizeDelta.x, backPackBgImg.sizeDelta.y);
                    backPackImg.anchoredPosition = new Vector2(backPackImg.anchoredPosition.x + 50, backPackImg.anchoredPosition.y);
                    backPackBgImg.anchoredPosition = new Vector2(backPackBgImg.anchoredPosition.x + 50, backPackBgImg.anchoredPosition.y);
                    InventoryManager.Instance.expendRight++;
                }
                break;
        }

        switch (index_Y)
        {
            case 0:
                if (InventoryManager.Instance.expendUp == 0)
                {
                    backPackImg.sizeDelta = new Vector2(backPackImg.sizeDelta.x, backPackImg.sizeDelta.y + rect.sizeDelta.y);
                    backPackBgImg.sizeDelta = new Vector2(backPackBgImg.sizeDelta.x, backPackBgImg.sizeDelta.y + +rect.sizeDelta.y);
                    backPackImg.anchoredPosition = new Vector3(backPackImg.anchoredPosition.x, backPackImg.anchoredPosition.y + 50);
                    backPackBgImg.anchoredPosition = new Vector3(backPackBgImg.anchoredPosition.x, backPackBgImg.anchoredPosition.y + 50);
                    InventoryManager.Instance.expendUp++;
                }
                break;
            case 4:
                if (InventoryManager.Instance.expendDown == 0)
                {
                    backPackImg.sizeDelta = new Vector2(backPackImg.sizeDelta.x, backPackImg.sizeDelta.y + rect.sizeDelta.y);
                    backPackBgImg.sizeDelta = new Vector2(backPackBgImg.sizeDelta.x, backPackBgImg.sizeDelta.y + rect.sizeDelta.y);
                    backPackImg.anchoredPosition = new Vector3(backPackImg.anchoredPosition.x, backPackImg.anchoredPosition.y - 50);
                    backPackBgImg.anchoredPosition = new Vector3(backPackBgImg.anchoredPosition.x, backPackBgImg.anchoredPosition.y - 50);
                    InventoryManager.Instance.expendDown++;
                }
                break;
        }
    }

}
