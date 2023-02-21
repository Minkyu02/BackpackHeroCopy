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
    public List<GameObject> enemyList = null;
    // 미니맵에서 적 구역을 눌렀을 때 Instantiate하면서 몬스터의 정보를 List에다가 넣어줌, Enemy의 체력이 0이 될 때 리스트에서 삭제 리스트가 비어있을 때 LevelUpCheck 실행
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
        if (playerNowHp <= 0) {
            Die();
        }
    }

    private void Die() {

    }

    public void LevelUpCheck() //전투가 끝날 때 한번 확인
    {
        if (playerExp >= playerNextExp)
        {
            GameManager.Instance.RootMode();
            // 게임매니저의 배틀모드 비활성화, 루트모드 활성화
            // 레벨업 버튼 활성화
        }
        else //레벨업 안했을 경우 
        {
            GameManager.Instance.IdleMode();
            // 배틀모드 비활성화, idle모드 활성화
        }
    }
}
