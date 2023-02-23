using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : SingleTonBase<ButtonManager>
{
    // Start is called before the first frame update

    public GameObject btn_BagUpgrade = null;
    public GameObject btn_BagUpgradeFin = null;
    public GameObject btn_ChooseFin = null;
    public GameObject btn_EndTurn = null;
    public GameObject btn_SwapTop = null;
    public GameObject btn_ItemCreate = null;
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
