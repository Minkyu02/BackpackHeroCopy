using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Item : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    protected RectTransform itemRect = null;
    public GameObject mostNearInventory = null;
    protected GameObject prevNearInventory = null;
    protected GameObject itemBackImgPrefebs = null;
    protected GameObject[] itemSize = new GameObject[9];
    protected List<GameObject> inInventory = new List<GameObject>();
    protected InventoryBg inventoryBg = null;
    private Vector3 point = Vector3.zero;
    protected Vector2 setPos = Vector2.zero;
    protected bool isSelect = false;
    protected bool isInit = false;
    protected bool InventoryCheck = false;
    protected bool itemUseAble = true;
    public bool isValue = false;
    protected int slotCount = 0;
    protected int itemSlotCount = 0;
    protected int rotateCount = 0;
    protected int itemUseCount = 0;


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
            itemSize[i].name = $"{itemSize[i].name}_{i}";
        }
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        MousePoint();
        RotateItem();
        UseCheck();
    }

    protected virtual void RotateItem()
    {
        if (Input.GetMouseButtonDown(1) && isSelect)
        {
            itemRect.rotation = itemRect.rotation * Quaternion.Euler(0, 0, 90);
            rotateCount++;
            if (rotateCount > 3)
            {
                rotateCount = 0;
            }
            SlotCheck();
        }
    }
    private void MousePoint()
    {
        point = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, -Camera.main.transform.position.z));
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (isInit && GameManager.Instance.rootMode)
        {
            isInit = false;
            OutInventory();
        }
        if (Input.GetMouseButtonDown(0) && GameManager.Instance.rootMode)
        {
            isSelect = true;
            for (int i = 0; i < inInventory.Count; i++)
            {
                inInventory[i].GetComponent<InventoryBg>().isHave = false;
            }
        }
        else if (Input.GetMouseButtonDown(0) && GameManager.Instance.battleMode && itemUseAble)
        {
            OnUse();
        }
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        if (Input.GetMouseButtonUp(0) && GameManager.Instance.rootMode)
        {
            isSelect = false;
            if (isInit)
            {
                DistancePockets();
                for (int i = 0; i < inInventory.Count; i++)
                {
                    inInventory[i].GetComponent<InventoryBg>().isHave = true;
                }
                transform.position = mostNearInventory.transform.position;
                gameObject.transform.GetChild(2).GetComponent<Image>().enabled = false;
                InitInventory();
                isValue = true;
            }
            else
            {
                transform.localPosition = new Vector2(Random.Range(-800f,700f),Random.Range(-300f,-500f));
                gameObject.transform.GetChild(3).GetComponent<Image>().enabled = false;
                gameObject.transform.GetChild(3).position = transform.position;
                isValue = false;
            }
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

    private void OnUse()
    {
        if (PlayerManager.Instance.playerActionPoint - itemUseCount >= 0)
        {
            PlayerManager.Instance.playerActionPoint -= itemUseCount;
            ItemEffect();
        }
    }

    protected virtual void ItemEffect() {

    }


    protected virtual void UseCheck() {
        if (PlayerManager.Instance.playerActionPoint - itemUseCount < 0){
            itemUseAble = false;
        }
        if (!itemUseAble) {
            transform.GetChild(1).GetChild(0).GetComponent<Image>().color = new Color(0.2f,0.2f,0.2f,255);

        }
        else {
            transform.GetChild(1).GetChild(0).GetComponent<Image>().color = new Color(1f,1f,1f,255);
        }
    }

    protected delegate void SetAbleDel();
    protected delegate void SetAbleDelPos(Vector2 pos_);
    protected SetAbleDel setDel = default;
    protected SetAbleDelPos setDelPos = default;
    protected virtual void DistancePockets()
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
                        SlotCheck();
                        // for (int j = 0; j < itemActive.Count; j++)
                        // {

                        // }
                        // Debug.Log("false");
                        // Debug.Log($"전꺼 2차원 배열 : {mostNearInventory.GetComponent<InventoryBg>().index_X}, {mostNearInventory.GetComponent<InventoryBg>().index_Y}");
                    }
                    if (setDel != null)
                    {
                        setDel.Invoke();
                    }
                    setDelPos?.Invoke(setPos);
                    prevNearInventory = mostNearInventory;
                    // SetAble();
                    // Debug.Log($"2차원 배열 : {inventoryBg.index_X}, {inventoryBg.index_Y}");
                    // Debug.Log($"2차원 배열 : {InventoryManager.Instance.backPack.GetIndex2D(i)}");
                }
            }
            else
            {
                if (Vector2.Distance(transform.position, InventoryManager.Instance.backpackArray[i].transform.position) <= 0.5)
                {
                    gameObject.transform.GetChild(2).GetComponent<Image>().enabled = false;
                    gameObject.transform.GetChild(2).position = transform.position;
                    isInit = false;
                    gameObject.transform.GetChild(3).GetComponent<Image>().enabled = false;
                    gameObject.transform.GetChild(3).position = transform.position;
                }
            }
        }
    }

    protected virtual void SetAble()
    {
        if (slotCount == itemSlotCount)
        {
            gameObject.transform.GetChild(3).GetComponent<Image>().enabled = false;
            gameObject.transform.GetChild(3).position = transform.position;
            gameObject.transform.GetChild(2).GetComponent<Image>().enabled = true;
            gameObject.transform.GetChild(2).position = mostNearInventory.transform.position;
            isInit = true;
        }
        else
        {
            gameObject.transform.GetChild(3).GetComponent<Image>().enabled = true;
            gameObject.transform.GetChild(3).position = mostNearInventory.transform.position;
            gameObject.transform.GetChild(2).GetComponent<Image>().enabled = false;
            gameObject.transform.GetChild(2).position = transform.position;
            isInit = false;

        }
    }
    protected virtual void SetAble(Vector2 pos_)
    {
        if (slotCount == itemSlotCount)
        {
            gameObject.transform.GetChild(3).GetComponent<Image>().enabled = false;
            gameObject.transform.GetChild(3).position = transform.position;
            gameObject.transform.GetChild(2).GetComponent<Image>().enabled = true;
            RectTransform rect = mostNearInventory.GetComponent<RectTransform>();
            switch (rotateCount)
            {
                case 0:
                    Vector3 rotatePos_ = new Vector3(pos_.x, pos_.y, 0f) * 0.01f;
                    gameObject.transform.GetChild(2).position = mostNearInventory.transform.position + rotatePos_;
                    break;
                case 1:
                    rotatePos_ = new Vector3(pos_.x * -1, pos_.y, 0f) * 0.01f;
                    gameObject.transform.GetChild(2).position = mostNearInventory.transform.position + rotatePos_;
                    break;
                case 2:
                    rotatePos_ = new Vector3(pos_.x * -1, pos_.y * -1, 0f) * 0.01f;
                    gameObject.transform.GetChild(2).position = mostNearInventory.transform.position + rotatePos_;
                    break;
                case 3:
                    rotatePos_ = new Vector3(pos_.x, pos_.y * -1, 0f) * 0.01f;
                    gameObject.transform.GetChild(2).position = mostNearInventory.transform.position + rotatePos_;
                    break;
            }
            // gameObject.transform.GetChild(2).position = mostNearInventory.transform.position + (Vector3)pos_ * 0.01f;
            isInit = true;
        }
        else
        {
            gameObject.transform.GetChild(3).GetComponent<Image>().enabled = true;
            switch (rotateCount)
            {
                case 0:
                    Vector3 rotatePos_ = new Vector3(pos_.x, pos_.y, 0f) * 0.01f;
                    gameObject.transform.GetChild(3).position = mostNearInventory.transform.position + rotatePos_;
                    break;
                case 1:
                    rotatePos_ = new Vector3(pos_.x * -1, pos_.y, 0f) * 0.01f;
                    gameObject.transform.GetChild(3).position = mostNearInventory.transform.position + rotatePos_;
                    break;
                case 2:
                    rotatePos_ = new Vector3(pos_.x * -1, pos_.y * -1, 0f) * 0.01f;
                    gameObject.transform.GetChild(3).position = mostNearInventory.transform.position + rotatePos_;
                    break;
                case 3:
                    rotatePos_ = new Vector3(pos_.x, pos_.y * -1, 0f) * 0.01f;
                    gameObject.transform.GetChild(3).position = mostNearInventory.transform.position + rotatePos_;
                    break;
            }

            // gameObject.transform.GetChild(3).position = mostNearInventory.transform.position + (Vector3)pos_ * 0.01f;
            // gameObject.transform.GetChild(3).position = mostNearInventory.transform.position;
            gameObject.transform.GetChild(2).GetComponent<Image>().enabled = false;
            gameObject.transform.GetChild(2).position = transform.position;
            isInit = false;
        }
    }

    // 생각해볼것 

    protected void SlotCheck()
    {
        slotCount = 0;
        RotateCheck();
    }

    private void InitInventory()
    {
        for (int i = 0; i < itemSize.Length; i++)
        {
            if (itemSize[i].GetComponent<ItemSlot>().isActive)
            {
                itemSize[i].GetComponent<Image>().enabled = true;
            }
        }
        
    }

    private void OutInventory()
    {
        for (int i = 0; i < itemSize.Length; i++)
        {
            itemSize[i].GetComponent<Image>().enabled = false;
        }
    }

    private void RotateCheck()
    {
        inInventory.Clear();
        int index_X = mostNearInventory.GetComponent<InventoryBg>().index_X;
        int index_Y = mostNearInventory.GetComponent<InventoryBg>().index_Y;
        int i = -1;
        switch (rotateCount)
        {
            case 0:
                for (int y = index_Y - 1; y <= index_Y + 1; y++)
                {
                    for (int x = index_X - 1; x <= index_X + 1; x++)
                    {
                        i++;
                        if ( (0 > x || x > InventoryManager.Instance.backpack2Array.GetUpperBound(1)) || (0 > y ||  y > InventoryManager.Instance.backpack2Array.GetUpperBound(0)))
                        {
                            continue;
                        }

                        if (!InventoryManager.Instance.backpack2Array[y, x].GetComponent<InventoryBg>().isActive)
                        {
                            continue;
                        }
                        else
                        {
                            if (InventoryManager.Instance.backpack2Array[y, x].GetComponent<InventoryBg>().isActive && itemSize[i].GetComponent<ItemSlot>().isActive && !InventoryManager.Instance.backpack2Array[y, x].GetComponent<InventoryBg>().isHave)
                            {
                                inInventory.Add(InventoryManager.Instance.backpack2Array[y, x]);
                                slotCount++;
                            }
                        }
                    } // 인벤토리를 서치하는 X
                } // 인벤토리를 서치하는 Y
                break;
            case 1: // 한번 회전
                for (int x = index_X - 1; x <= index_X + 1; x++)
                {
                    for (int y = index_Y + 1; y >= index_Y - 1; y--)
                    {
                        i++;
                        if ((0 > x || x > InventoryManager.Instance.backpack2Array.GetUpperBound(1)) || (0 > y ||  y > InventoryManager.Instance.backpack2Array.GetUpperBound(0)))
                        {
                            continue;
                        }

                        if (!InventoryManager.Instance.backpack2Array[y, x].GetComponent<InventoryBg>().isActive)
                        {
                            continue;
                        }
                        else
                        {
                            if (InventoryManager.Instance.backpack2Array[y, x].GetComponent<InventoryBg>().isActive && itemSize[i].GetComponent<ItemSlot>().isActive && !InventoryManager.Instance.backpack2Array[y, x].GetComponent<InventoryBg>().isHave)
                            {
                                inInventory.Add(InventoryManager.Instance.backpack2Array[y, x]);
                                slotCount++;
                            }
                        }
                    } // 인벤토리를 서치하는 X
                } // 인벤토리를 서치하는 Y
                break;
            case 2:
                for (int y = index_Y + 1; y >= index_Y - 1; y--)
                {
                    for (int x = index_X + 1; x >= index_X - 1; x--)
                    {
                        i++;
                        if ((0 > x || x > InventoryManager.Instance.backpack2Array.GetUpperBound(1)) || (0 > y ||  y > InventoryManager.Instance.backpack2Array.GetUpperBound(0)))
                        {
                            continue;
                        }

                        if (!InventoryManager.Instance.backpack2Array[y, x].GetComponent<InventoryBg>().isActive)
                        {
                            continue;
                        }
                        else
                        {
                            if (InventoryManager.Instance.backpack2Array[y, x].GetComponent<InventoryBg>().isActive && itemSize[i].GetComponent<ItemSlot>().isActive && !InventoryManager.Instance.backpack2Array[y, x].GetComponent<InventoryBg>().isHave)
                            {
                                inInventory.Add(InventoryManager.Instance.backpack2Array[y, x]);
                                slotCount++;
                            }
                        }
                    } // 인벤토리를 서치하는 X
                } // 인벤토리를 서치하는 Y
                break;
            case 3:
                for (int x = index_X + 1; x >= index_X - 1; x--)
                {
                    for (int y = index_Y - 1; y <= index_Y + 1; y++)
                    {
                        i++;
                        if ((0 > x || x > InventoryManager.Instance.backpack2Array.GetUpperBound(1)) || (0 > y ||  y > InventoryManager.Instance.backpack2Array.GetUpperBound(0)))
                        {
                            continue;
                        }

                        if (!InventoryManager.Instance.backpack2Array[y, x].GetComponent<InventoryBg>().isActive)
                        {
                            continue;
                        }
                        else
                        {
                            if (InventoryManager.Instance.backpack2Array[y, x].GetComponent<InventoryBg>().isActive && itemSize[i].GetComponent<ItemSlot>().isActive && !InventoryManager.Instance.backpack2Array[y, x].GetComponent<InventoryBg>().isHave)
                            {
                                inInventory.Add(InventoryManager.Instance.backpack2Array[y, x]);
                                slotCount++;
                            }
                        }
                    } // 인벤토리를 서치하는 X
                } // 인벤토리를 서치하는 Y
                break;
        }
    }

}
