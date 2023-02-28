using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTurn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ButtonManager.Instance.btn_EndTurn = this.gameObject;
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (BattleManager.Instance.isBattleEnd)
        {
            gameObject.SetActive(false);
        }
    }
    public void Btn_TurnChange()
    {
        if (BattleManager.Instance.isPlayerTurn)
        {
            BattleManager.Instance.isPlayerTurn = false;
            gameObject.SetActive(false);
            BattleManager.Instance.EnemyBattle();
        }
    }
}
