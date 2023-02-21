using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : Item
{
    protected override void Start()
    {
        base.Start();
        itemSlotCount = 4;
        setPos = new Vector2(0, 50);
        itemSize[1].GetComponent<ItemSlot>().isActive = true;
        itemSize[2].GetComponent<ItemSlot>().isActive = true;
        itemSize[3].GetComponent<ItemSlot>().isActive = true;
        itemSize[4].GetComponent<ItemSlot>().isActive = true;
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
    }

    protected override void DistancePockets()
    {
        this.setDelPos = this.SetAble;
        base.DistancePockets();
    }

    protected override void SetAble(Vector2 pos_)
    {
        base.SetAble(pos_);

    }

    protected override void RotateItem()
    {
        if (Input.GetMouseButtonDown(1) && isSelect)
        {
            itemRect.rotation = itemRect.rotation * Quaternion.Euler(0, 0, 90);
            rotateCount++;
            if (rotateCount > 3)
            {
                rotateCount = 0;
            }
            SwapVector(ref setPos);
            SlotCheck();
        }
    }

    private void SwapVector(ref Vector2 pos_) {
        pos_ = new Vector2(pos_.y,pos_.x);
    }
}
