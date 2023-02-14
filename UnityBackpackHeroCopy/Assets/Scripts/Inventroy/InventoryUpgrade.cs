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
    private GameObject[] backpackArray;
    private GameObject[,] backpack2Array;
    public GameObject backpackBg = null;
    private RectTransform backpackBgRect = null;
    private GameObject nowPockets = null;
    private float nowPocketsWidth = 0f;
    private float nowPocketsHeight = 0f;
    public int upgradeCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        backpackBgRect = backpackBg.GetComponent<RectTransform>();
        nowPockets = transform.GetChild(0).gameObject;
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
        int x = 0;
        int y = 0;
        for (int i = 0; i < totalCount; i++)
        {
            GameObject bg = Instantiate(backpackBg);
            bg.transform.position = new Vector3(-300 + (100 * x), 200 - (100 * y), 0);
            backpackArray[i] = bg;
            bg.GetComponent<InventoryBg>().index = i;
            bg.name = $"{backpackBg.name}_{i}";
            backpack2Array[y, x] = bg;
            bg.GetComponent<InventoryBg>().index_X = x;
            bg.GetComponent<InventoryBg>().index_Y = y;
            x++;
            if (x >= widthCount)
            {
                x = 0;
                y++;
            }
            bg.transform.SetParent(gameObject.transform.GetChild(1), false);
            bg.SetActive(false);
        }
    }

    private void BaseSetting()
    {
        for (int y = 1; y < 4; y++)
        {
            for (int x = 2; x < 5; x++)
            {
                backpack2Array[y, x].SetActive(true);
                backpack2Array[y, x].transform.SetParent(nowPockets.transform, false);
                backpack2Array[y, x].GetComponent<InventoryBg>().isActive = true;
            }
        }
    }
    private void LevelUp()
    {
        if (isLevelup)
        {
            if (upgradeCount >= 0)
            {
                SelectMode();
            }
            else if (upgradeCount <= 0)
            {
                isLevelup = false;
            }
        }
    }

    private void SelectMode()
    {
        for (int i = 0; i < backpackArray.Length; i++)
        {
            backpackArray[i].SetActive(true);
            backpackArray[i].transform.GetChild(0).gameObject.SetActive(false);
            backpackArray[i].transform.GetChild(1).gameObject.SetActive(true);
            if (backpackArray[i].GetComponent<InventoryBg>().isActive)
            {
                backpackArray[i].transform.GetChild(0).gameObject.SetActive(true);
                backpackArray[i].transform.GetChild(1).gameObject.SetActive(false);
            }
        }
    }

    public void NormalMode()
    {
        for (int i = 0; i < backpackArray.Length; i++)
        {
            if (!backpackArray[i].GetComponent<InventoryBg>().isActive)
            {
                backpackArray[i].transform.GetChild(0).gameObject.SetActive(false);
                backpackArray[i].transform.GetChild(1).gameObject.SetActive(false);
                isLevelup = false;
            }
        }
    }

}
