using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : SingleTonBase<GameManager>
{
    public GameObject stage1 = null;
    public GameObject stage2 = null;
    public GameObject dieScene = null;
    public GameObject nextStageDoor = null;
    public GameObject playerTurntext = null;
    public GameObject stageLoad = null;
    public GameObject chest = null;
    public List<Transform> playMaps = null;
    public int upgradeCount = 0;
    public bool rootMode = false;
    public bool battleMode = false;
    public bool idleMode = false;

    public void Init()
    {
        dieScene = null;
        nextStageDoor = null;
        playerTurntext = null;
        chest = null;
        playMaps = new List<Transform>();
        upgradeCount = 0;
        rootMode = true;
        battleMode = false;
        idleMode = false;
    }
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
    }

    public void IdleMode()
    {
        rootMode = false;
        battleMode = false;
        idleMode = true;
    }

    public void RootMode()
    {
        rootMode = true;
        battleMode = false;
        idleMode = false;
    }

    public void BattleMode()
    {
        rootMode = false;
        battleMode = true;
        idleMode = false;
    }

}
