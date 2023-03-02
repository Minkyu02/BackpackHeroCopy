using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Food : Item
{
    private int itemLeft = 2;
    public Sprite useImg = null;
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        itemSlotCount = 2;
        setPos = new Vector2(50, 0);
        itemSize[4].GetComponent<ItemSlot>().isActive = true;
        itemSize[5].GetComponent<ItemSlot>().isActive = true;
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

    private void SwapVector(ref Vector2 pos_)
    {
        pos_ = new Vector2(pos_.y, pos_.x);
    }

    protected override void ItemEffect()
    {
        if (PlayerManager.Instance.delay == null)
        {
            PlayerManager.Instance.isUseItem = true;
            base.ItemEffect();
            itemLeft--;
            gameObject.transform.GetChild(1).GetChild(0).GetComponent<Image>().sprite = useImg;
            PlayerManager.Instance.playerActionPoint += 2;
        }
        else
        {
            StopCoroutine(PlayerManager.Instance.MotionDelay());
            PlayerManager.Instance.delay = null;
            PlayerManager.Instance.isUseItem = false;
            ItemEffect();
        }
    }

    protected override void UseCheck()
    {
        if (itemLeft <= 0)
        {
            for (int i = 0; i < inInventory.Count; i++)
            {
                inInventory[i].GetComponent<InventoryBg>().isHave = false;
            }
            Destroy(gameObject);
        }
    }
}
