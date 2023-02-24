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
        PlayerManager.Instance.isAttacked = false;
        StartCoroutine(DelayItemEffect());
    }

    IEnumerator DelayItemEffect()
    {
        yield return null;
        PlayerManager.Instance.isAttacked = true;
        int unSelectedEnemy = 0;
        for (int i = 0; i < BattleManager.Instance.enemyList.Count; i++)
        {
            if (BattleManager.Instance.enemyList[i].GetComponent<Enemy>().isSelect)
            {
                if (BattleManager.Instance.enemyList[i].GetComponent<Enemy>().shieldRate > 0)
                {
                    BattleManager.Instance.enemyList[i].GetComponent<Enemy>().shieldRate -= 7;
                    if (BattleManager.Instance.enemyList[i].GetComponent<Enemy>().shieldRate < 0)
                    {
                        BattleManager.Instance.enemyList[i].GetComponent<Enemy>().nowHp += BattleManager.Instance.enemyList[i].GetComponent<Enemy>().shieldRate;
                    }
                }
                else
                {
                    BattleManager.Instance.enemyList[i].GetComponent<Enemy>().nowHp -= 7;
                }
            }
            else
            {
                unSelectedEnemy++;
            }
        }
        if (unSelectedEnemy == BattleManager.Instance.enemyList.Count)
        {
            if (BattleManager.Instance.enemyList[0].GetComponent<Enemy>().shieldRate > 0)
            {
                BattleManager.Instance.enemyList[0].GetComponent<Enemy>().shieldRate -= 7;
                if (BattleManager.Instance.enemyList[0].GetComponent<Enemy>().shieldRate < 0)
                {
                    BattleManager.Instance.enemyList[0].GetComponent<Enemy>().nowHp += BattleManager.Instance.enemyList[0].GetComponent<Enemy>().shieldRate;
                }
            }
            else
            {
                BattleManager.Instance.enemyList[0].GetComponent<Enemy>().nowHp -= 7;
            }
        }
    }
}
