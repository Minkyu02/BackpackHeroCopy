using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatEnemy : MonoBehaviour
{
    public GameObject enemyPrefebs = null;
    private GameObject enemy = null;
    // Start is called before the first frame update
    void Start()
    {
        ButtonManager.Instance.btn_CreateEnemy = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Btn_CreateEnemy()
    {
        PlayerManager.Instance.playerActionPoint = 3;
        for (int i = 0; i < Random.Range(1f, 3f); i++)
        {
            enemy = Instantiate(enemyPrefebs);
            enemy.transform.SetParent(GameObject.Find("GameObjs").transform, false);
            enemy.transform.localPosition = new Vector3(300 + 200 * i, -360f, 0f);
            BattleManager.Instance.enemyList.Add(enemy);
            GameManager.Instance.BattleMode();
            BattleManager.Instance.isBattleEnd = false;
            ButtonManager.Instance.btn_EndTurn.SetActive(true);
        }
    }
}
