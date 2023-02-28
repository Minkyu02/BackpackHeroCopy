using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class BattleManager : SingleTonBase<BattleManager>
{
    public List<GameObject> enemyList = null;
    public bool isBattleEnd = true;
    public bool isPlayerTurn = true;
    public bool isRestTime = false;


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
        BattleEndCheck();
    }

    public void BattleEndCheck()
    {
        if (!enemyList.Any() && !isBattleEnd)
        {
            isBattleEnd = true;
            isRestTime = true;
            PlayerManager.Instance.LevelUpCheck();
        }
    }


    public void EnemyBattle()
    {
        if (!isPlayerTurn)
        {
            StartCoroutine(EnemyAttackDelay());
        }
    }

    IEnumerator EnemyAttackDelay()
    {
        for (int i = 0; i < enemyList.Count; i++)
        {
            enemyList[i].GetComponent<Enemy>().Battle();
            yield return new WaitForSeconds(0.25f);
            enemyList[i].GetComponent<Enemy>().isAttackFin = false;
            enemyList[i].GetComponent<Enemy>().isDefFin = false;
            yield return new WaitForSeconds(0.25f);
            enemyList[i].GetComponent<Enemy>().isAttack = false;
            enemyList[i].GetComponent<Enemy>().isAttackFin = true;
            enemyList[i].GetComponent<Enemy>().isDef = false;
            enemyList[i].GetComponent<Enemy>().isDefFin = true;
        }
        GameManager.Instance.playerTurntext.SetActive(true);
        for (int i = 0; i < enemyList.Count; i++)
        {
            enemyList[i].GetComponent<Enemy>().NextBehavior();
        }
        PlayerManager.Instance.playerShieldRate = 0;
        PlayerManager.Instance.playerActionPoint = 3;
    }
}
