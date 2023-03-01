using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : SingleTonBase<PlayerManager>
{
    public int playerActionPoint = 3;
    public int playerLevel = 0;
    public int playerExp = 0;
    public int playerNextExp = 10;
    public int PlayerFloor = 0;
    public int playerMaxHp = 40;
    public int playerNowHp = 40;
    public int playerShieldRate = 0;
    public int mapPlayerPos = 0;
    public int targetPos = 0;
    public bool isMap = false;
    public bool isPlayerTurn = true;
    public bool isLevelUp = false;
    public bool isAttack = false;
    public bool isWalk = false;
    public bool isDie = false;
    public bool isAttacked = false;
    public bool isUseItem = false;
    public bool isWin = false;
    public GameObject mapPlayerIcon = null;
    public RectTransform playerPos = null;
    public Coroutine delay = null;

    protected override void Awake()
    {
        base.Awake();
    }

    protected override void Start()
    {
        base.Start();
        SceneManager.LoadScene("01. Title");
    }
    protected override void Update()
    {
        base.Update();
        Die();
        if (isUseItem)
        {
            if (delay == null)
            {
                delay = StartCoroutine(MotionDelay());
            }
        }
    }
    public IEnumerator MotionDelay()
    {
        yield return new WaitForSeconds(1.0f);
        isUseItem = false;
        delay = null;
    }
    private void Die()
    {
        if (playerNowHp <= 0 && !isDie)
        {
            isDie = true;
            GameManager.Instance.dieScene.SetActive(true);
        }
    }

    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "01. Title")
        {
            Init();
            GameManager.Instance.Init();
            BattleManager.Instance.Init();
            InventoryManager.Instance.Init();
        }
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }


    private void Init()
    {
        playerActionPoint = 3;
        playerLevel = 0;
        playerExp = 0;
        playerNextExp = 10;
        PlayerFloor = 0;
        playerMaxHp = 40;
        playerNowHp = 40;
        playerShieldRate = 0;
        mapPlayerPos = 0;
        targetPos = 0;
        isMap = false;
        isPlayerTurn = true;
        isLevelUp = false;
        isAttack = false;
        isWalk = false;
        isDie = false;
        isAttacked = false;
        isUseItem = false;
    }
    public void LevelUpCheck() //전투가 끝날 때 한번 확인
    {
        if (playerExp >= playerNextExp)
        {
            isLevelUp = true;
            ButtonManager.Instance.btn_BagUpgrade.SetActive(true);
            PlayerManager.Instance.playerActionPoint = 3;
            GameManager.Instance.IdleMode();
            // Test.BroadcastMessage("LevelUpTest", SendMessageOptions.DontRequireReceiver);
            // 게임매니저의 배틀모드 비활성화, 루트모드 활성화
            // 레벨업 버튼 활성화
        }
        else //레벨업 안했을 경우 
        {
            PlayerManager.Instance.playerActionPoint = 3;
            ButtonManager.Instance.btn_ItemCreate.SetActive(true);
            GameManager.Instance.IdleMode();
        }
    }



}
