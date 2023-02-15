using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUpgrade : MonoBehaviour
{
    private const int BACKPACK_WIDTH = 700;
    private const int BACKPACK_HEIGHT = 500;
    private int backpackBgSize = default;
    private int totalCount = 0;
    private int widthCount = 0;
    private int heightCount = 0;
    public bool isLevelup = false;
    public GameObject[] backpackArray;
    public GameObject[,] backpack2Array;
    public GameObject backpackBg = null;
    private RectTransform backpackBgRect = null;
    private GameObject nowPockets = null;
    private float nowPocketsWidth = 0f;
    private float nowPocketsHeight = 0f;
    // Start is called before the first frame update
    void Start()
    {
        backpackBgRect = backpackBg.GetComponent<RectTransform>();
        nowPockets = transform.GetChild(2).gameObject;
        InventoryManager.Instance.backPack = this;
        CreatePocket();
        BaseSetting();

    }

    // Update is called once per frame
    void Update()
    {
        LevelUp();
    }

    private void CreatePocket()
    {
        backpackBgSize = (int)backpackBgRect.sizeDelta.x;
        widthCount = (BACKPACK_WIDTH / backpackBgSize); // 7
        heightCount = (BACKPACK_HEIGHT / backpackBgSize); // 5
        totalCount = widthCount * heightCount;
        backpackArray = new GameObject[totalCount];
        backpack2Array = new GameObject[heightCount, widthCount];
        InventoryManager.Instance.backpackArray = new GameObject[totalCount];
        InventoryManager.Instance.backpack2Array = new GameObject[heightCount, widthCount];
        int x = 0;
        int y = 0;
        for (int i = 0; i < totalCount; i++)
        {
            GameObject bg = Instantiate(backpackBg);
            bg.transform.position = new Vector3(-300 + (100 * x), 200 - (100 * y), 0);
            backpackArray[i] = bg;
            InventoryManager.Instance.backpackArray[i] = bg;
            bg.GetComponent<InventoryBg>().index = i;
            bg.name = $"{backpackBg.name}_{i}";
            backpack2Array[y, x] = bg;
            InventoryManager.Instance.backpack2Array[y, x] = bg;
            bg.GetComponent<InventoryBg>().index_X = x;
            bg.GetComponent<InventoryBg>().index_Y = y;
            x++;
            if (x >= widthCount)
            {
                x = 0;
                y++;
            }
            backpackArray[i].GetComponent<InventoryBg>().OnActive();

            bg.transform.SetParent(gameObject.transform.GetChild(3), false);
        }
    }

    private void BaseSetting()
    {
        for (int y = 1; y < 4; y++)
        {
            for (int x = 2; x < 5; x++)
            {
                backpack2Array[y, x].GetComponent<InventoryBg>().isActive = true;
                backpack2Array[y, x].GetComponent<InventoryBg>().OnActive();
                backpack2Array[y, x].transform.SetParent(nowPockets.transform, false);
            }
        }
    }
    private void LevelUp()
    {
        if (isLevelup)
        {
            if (GameManager.Instance.upgradeCount >= 0)
            {
                SelectMode();
            }
            else if (GameManager.Instance.upgradeCount <= 0)
            {
                isLevelup = false;
                NormalMode();
            }
        }
    }

    private void SelectMode()
    {
        for (int y = 0; y < heightCount; y++)
        {
            for (int x = 0; x < widthCount; x++)
            {
                if (backpack2Array[y, x].GetComponent<InventoryBg>().isActive)
                {
                    if (y < heightCount - 1 && y > 0 && !backpack2Array[y + 1, x].GetComponent<InventoryBg>().isActive)
                    {
                        if (backpack2Array[y + 1, x].GetComponent<InventoryBg>().isChoose)
                        {
                            backpack2Array[y + 1, x].GetComponent<InventoryBg>().OnSelect();
                        }
                        else
                        {
                            backpack2Array[y + 1, x].GetComponent<InventoryBg>().OnSelectAble();
                        }
                    }
                    if (y < heightCount && y > 0 && !backpack2Array[y - 1, x].GetComponent<InventoryBg>().isActive)
                    {
                        if (backpack2Array[y - 1, x].GetComponent<InventoryBg>().isChoose)
                        {
                            backpack2Array[y - 1, x].GetComponent<InventoryBg>().OnSelect();
                        }
                        else
                        {
                            backpack2Array[y - 1, x].GetComponent<InventoryBg>().OnSelectAble();
                        }
                    }
                    if (x < widthCount && x > 0 && !backpack2Array[y, x - 1].GetComponent<InventoryBg>().isActive)
                    {
                        if (backpack2Array[y, x - 1].GetComponent<InventoryBg>().isChoose)
                        {
                            backpack2Array[y, x - 1].GetComponent<InventoryBg>().OnSelect();
                        }
                        else
                        {

                            backpack2Array[y, x - 1].GetComponent<InventoryBg>().OnSelectAble();
                        }
                    }
                    if (x < widthCount - 1 && x > 0 && !backpack2Array[y, x + 1].GetComponent<InventoryBg>().isActive)
                    {
                        if (backpack2Array[y, x + 1].GetComponent<InventoryBg>().isChoose)
                        {
                            backpack2Array[y, x + 1].GetComponent<InventoryBg>().OnSelect();
                        }
                        else
                        {
                            backpack2Array[y, x + 1].GetComponent<InventoryBg>().OnSelectAble();
                        }

                    }
                }
            }
        }
        // for (int i = 0; i < backpackArray.Length; i++)
        // {
        //     if (backpackArray[i].GetComponent<InventoryBg>().isChoose)
        //     {
        //         backpackArray[i].GetComponent<InventoryBg>().OnSelect();
        //     }
        //     else
        //     {
        //         backpackArray[i].GetComponent<InventoryBg>().OnSelectAble();
        //     }
        // }
    }

    public void NormalMode()
    {
        for (int i = 0; i < backpackArray.Length; i++)
        {
            backpackArray[i].GetComponent<InventoryBg>().OnActive();
            isLevelup = false;
        }
    }

    public Vector2Int GetIndex2D(int index_)
    {
        return new Vector2Int(index_ / widthCount, index_ % widthCount);
    }

    // public int GetIndex(Vector2Int index2D_) {


    // }


}
