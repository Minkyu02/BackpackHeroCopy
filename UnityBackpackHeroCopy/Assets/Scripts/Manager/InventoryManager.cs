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

    public void Init()
    {
        expendLeft = 0;
        expendRight = 0;
        expendUp = 0;
        expendDown = 0;
    }
    protected override void Awake()
    {
        base.Awake();
    }

    protected override void Start()
    {
        base.Start();
    }
    protected override void Update()
    {
        base.Update();
    }
}
