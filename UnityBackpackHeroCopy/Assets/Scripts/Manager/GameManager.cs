using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : SingleTonBase<GameManager>
{

    public int upgradeCount = 0;


    public bool rootMode = false;
    public bool battleMode = false;
    public bool idleMode = false;
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
