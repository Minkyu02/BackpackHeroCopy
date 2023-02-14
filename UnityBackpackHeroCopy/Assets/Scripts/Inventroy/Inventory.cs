using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // for (int y = 0; y < heightCount; y++)
    // {
    //     for (int x = 0; x < widthCount; x++)
    //     {
    //         if (backpack2Array[y, x].GetComponent<InventoryBg>().isActive)
    //         {
    //             if (y < heightCount - 1 && y > 0 && !backpack2Array[y + 1, x].GetComponent<InventoryBg>().isActive)
    //             {
    //                 backpack2Array[y + 1, x].SetActive(true);
    //                 backpack2Array[y + 1, x].transform.SetParent(nowPockets.transform, false);
    //                 backpack2Array[y, x].GetComponent<InventoryBg>().isActive = true;
    //             }
    //             if (y < heightCount && y > 0 && !backpack2Array[y - 1, x].GetComponent<InventoryBg>().isActive)
    //             {
    //                 backpack2Array[y - 1, x].SetActive(true);
    //                 backpack2Array[y - 1, x].transform.SetParent(nowPockets.transform, false);
    //                 backpack2Array[y, x].GetComponent<InventoryBg>().isActive = true;
    //             }
    //             if (x < widthCount && x > 0 && !backpack2Array[y, x - 1].GetComponent<InventoryBg>().isActive)
    //             {
    //                 backpack2Array[y, x - 1].SetActive(true);
    //                 backpack2Array[y, x - 1].transform.SetParent(nowPockets.transform, false);
    //                 backpack2Array[y, x].GetComponent<InventoryBg>().isActive = true;
    //             }
    //             if (x < widthCount - 1 && x > 0 && !backpack2Array[y, x + 1].GetComponent<InventoryBg>().isActive)
    //             {
    //                 backpack2Array[y, x + 1].SetActive(true);
    //                 backpack2Array[y, x + 1].transform.SetParent(nowPockets.transform, false);
    //                 backpack2Array[y, x].GetComponent<InventoryBg>().isActive = true;
    //             }
    //             isLevelup = false;
    //         }
    //     }
    // }
}
