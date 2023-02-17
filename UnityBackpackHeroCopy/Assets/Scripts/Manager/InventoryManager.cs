using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : SingleTonBase<InventoryManager>
{

    public int expendLeft = 0;
    public int expendRight = 0;
    public int expendUp = 0;
    public int expendDown = 0;
    public GameObject[] backpackArray;
    public GameObject[,] backpack2Array;
    public InventoryUpgrade backPack = null;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
}
