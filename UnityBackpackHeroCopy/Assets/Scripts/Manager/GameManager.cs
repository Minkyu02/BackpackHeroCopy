using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : SingleTonBase<GameManager>
{

    public int upgradeCount = 0;
    public bool isLevelup = false;

    public bool rootMode = false;
    public bool battleMode = true;
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
}
