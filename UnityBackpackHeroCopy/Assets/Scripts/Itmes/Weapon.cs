using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Weapon : Item
{
    private int useAbleCount = 1;

    protected override void Start()
    {
        base.Start();
        itemSlotCount = 2;
        setPos = new Vector2(50, 50);
        itemSize[2].GetComponent<ItemSlot>().isActive = true;
        itemSize[4].GetComponent<ItemSlot>().isActive = true;
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
        UseReSet();
    }

    private void UseReSet()
    {
        if (useAbleCount != 1 && BattleManager.Instance.isRestTime)
        {
            useAbleCount = 1;
        }
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
        base.ItemEffect();
        useAbleCount--;
        PlayerManager.Instance.isAttacked = false;
        StartCoroutine(DelayItemEffect());
    }

    IEnumerator DelayItemEffect()
    {
        yield return null;
        PlayerManager.Instance.isAttacked = true;
        for (int i = 0; i < BattleManager.Instance.enemyList.Count; i++)
        {
            if (BattleManager.Instance.enemyList[i].GetComponent<Enemy>().shieldRate > 0)
            {
                BattleManager.Instance.enemyList[i].GetComponent<Enemy>().shieldRate -= 3;
                if (BattleManager.Instance.enemyList[i].GetComponent<Enemy>().shieldRate < 0)
                {
                    BattleManager.Instance.enemyList[i].GetComponent<Enemy>().nowHp += BattleManager.Instance.enemyList[i].GetComponent<Enemy>().shieldRate;
                }
            }
            else
            {
                BattleManager.Instance.enemyList[i].GetComponent<Enemy>().nowHp -= 3;
            }
        }
    }


    protected override void UseCheck()
    {
        if (useAbleCount <= 0)
        {
            transform.GetChild(1).GetChild(0).GetComponent<Image>().color = new Color(0.2f, 0.2f, 0.2f, 255);
            itemUseAble = false;
        }
        else
        {
            itemUseAble = true;
            transform.GetChild(1).GetChild(0).GetComponent<Image>().color = new Color(1f, 1f, 1f, 255);
        }
    }
}
