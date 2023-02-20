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
        if (playerExp >= playerNextExp)
        {
            // 레벨업 버튼 활성화
        }
    }
}
