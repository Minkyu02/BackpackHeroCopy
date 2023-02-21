using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sword : Item
{
    // Start is called before the first frame update
    protected override void Start()
    {
        itemSize = new GameObject[9];
        base.Start();
        itemSlotCount = 3;
        itemUseCount = 1;
        itemSize[1].GetComponent<ItemSlot>().isActive = true;
        itemSize[4].GetComponent<ItemSlot>().isActive = true;
        itemSize[7].GetComponent<ItemSlot>().isActive = true;
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

    protected override void ItemEffect()
    {
        base.ItemEffect();
        Debug.Log("7데미지");
    }
}
