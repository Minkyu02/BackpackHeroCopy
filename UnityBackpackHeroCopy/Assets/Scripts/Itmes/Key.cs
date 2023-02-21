using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : Item
{
    protected override void Start()
    {
        itemSize = new GameObject[9];
        base.Start();
        itemSlotCount = 1;
        itemSize[4].GetComponent<ItemSlot>().isActive = true;
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
    }

    protected override void DistancePockets()
    {
        this.setDel = this.SetAble;
        base.DistancePockets();
    }
    protected override void SetAble()
    {
        base.SetAble();
    }
}
