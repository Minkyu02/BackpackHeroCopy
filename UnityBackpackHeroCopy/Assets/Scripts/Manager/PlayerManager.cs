using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : SingleTonBase<PlayerManager>
{
    public bool isMap = false;
    public int playerActionPoint = 3;
    public int playerLevel = 0;
    public int playerExp = 0;
    public int playerNextExp = 10;
    public int PlayerFloor = 0;
    public bool isPlayerTurn = true;
    public int playerMaxHp = 40;
    public int playerNowHp = 40;
    public bool isLevelUp = false;
    public bool isAttacked = false;
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
        Die();
    }

    private void Die()
    {
        if (playerNowHp <= 0)
        {

        }
    }

    public void LevelUpCheck() //전투가 끝날 때 한번 확인
    {
        if (playerExp >= playerNextExp)
        {
            isLevelUp = true;
            ButtonManager.Instance.btn_BagUpgrade.SetActive(true);
            GameManager.Instance.RootMode();
            // Test.BroadcastMessage("LevelUpTest", SendMessageOptions.DontRequireReceiver);
            // 게임매니저의 배틀모드 비활성화, 루트모드 활성화
            // 레벨업 버튼 활성화
        }
        else //레벨업 안했을 경우 
        {
            GameManager.Instance.isItemCreate = true;
            GameManager.Instance.RootMode();
            // 배틀모드 비활성화, idle모드 활성화
        }
    }



}
