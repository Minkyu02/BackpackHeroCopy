using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : Item
{
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        ItemSlotCount = 4;
        setPos = new Vector2(50,50);
        // itemSize[1].GetComponent<Image>().enabled = true;
        // itemSize[4].GetComponent<Image>().enabled = true;
        // itemSize[7].GetComponent<Image>().enabled = true;

        itemSize[1].GetComponent<ItemSlot>().isActive = true;
        itemSize[2].GetComponent<ItemSlot>().isActive = true;
        itemSize[4].GetComponent<ItemSlot>().isActive = true;
        itemSize[5].GetComponent<ItemSlot>().isActive = true;
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
    }

    protected override void DistancePockets() {
        this.setDelPos = this.SetAble;
        base.DistancePockets();
    }

    protected override void SetAble(Vector2 pos_)
    {
        base.SetAble(pos_);
        
    }
}
