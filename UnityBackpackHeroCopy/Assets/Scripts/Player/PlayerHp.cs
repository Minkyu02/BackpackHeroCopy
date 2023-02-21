using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHp : TextBase
{
    private Image hpBar = null;
    // Start is called before the first frame update
    protected override void Start()
    {
        hpBar = transform.parent.GetComponent<Image>();
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = $"{PlayerManager.Instance.playerNowHp} / {PlayerManager.Instance.playerMaxHp}";
        hpBar.fillAmount = (float)PlayerManager.Instance.playerNowHp  / (float)PlayerManager.Instance.playerMaxHp;
    }
}