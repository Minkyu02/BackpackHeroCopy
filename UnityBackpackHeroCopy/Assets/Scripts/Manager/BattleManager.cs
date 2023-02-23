using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class BattleManager : SingleTonBase<BattleManager>
{
    public List<GameObject> enemyList = null;
    public bool isBattleEnd = true;
    public bool isPlayerTurn = true;
    // 미니맵에서 적 구역을 눌렀을 때 Instantiate하면서 몬스터의 정보를 List에다가 넣어줌, Enemy의 체력이 0이 될 때 리스트에서 삭제, 리스트가 비어있을 때 LevelUpCheck 실행
    // Start is called before the first frame update


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
        for (int i = 0; i < enemyList.Count; i++) {
            enemyList[i].GetComponent<Enemy>().Battle();
            yield return new WaitForSeconds(0.25f);
            enemyList[i].GetComponent<Enemy>().isAttackFin = false;
            yield return new WaitForSeconds(0.25f);
            enemyList[i].GetComponent<Enemy>().isAttack = false;
            enemyList[i].GetComponent<Enemy>().isAttackFin = true;
        }
        isPlayerTurn = true;
        PlayerManager.Instance.playerActionPoint = 3;
    }
}
