using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextPlayerTurn : TextBase
{
    // Start is called before the first frame update
    private string playerTurn = "PLAYER TURN";

    protected override void Awake()
    {
        base.Awake();
        GameManager.Instance.playerTurntext = this.gameObject;

        gameObject.SetActive(false);
    }

    private void OnEnable() {
        StartCoroutine(Typing());
    }

    // Update is called once per frame
    private void Update()
    {

    }

    IEnumerator Typing()
    {
        BattleManager.Instance.isRestTime = true;
        for (int i = 0; i < playerTurn.Length; i++)
        {
            text.text = playerTurn.Substring(0, i + 1);
            yield return new WaitForSeconds(0.05f);
        }
        yield return new WaitForSeconds(0.1f);
        BattleManager.Instance.isPlayerTurn = true;
        BattleManager.Instance.isRestTime = false;
        gameObject.SetActive(false);
    }

}
