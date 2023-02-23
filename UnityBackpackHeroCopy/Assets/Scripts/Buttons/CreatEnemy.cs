using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CreatEnemy : MonoBehaviour, IPointerClickHandler
{
    private List<GameObject> enemyPrefebs = new List<GameObject>();
    private GameObject enemy = null;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <Resources.LoadAll<GameObject>("Prefebs/Enemy").Length; i++ ) {
            enemyPrefebs.Add(Resources.LoadAll<GameObject>("Prefebs/Enemy")[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnPointerClick(PointerEventData eventData)
    {
        PlayerManager.Instance.playerActionPoint = 3;
        for (int i = 0; i < Random.Range(1, 4); i++)
        {
            enemy = Instantiate(enemyPrefebs[Random.Range(0,Resources.LoadAll<GameObject>("Prefebs/Enemy").Length)]);
            enemy.transform.SetParent(GameObject.Find("GameObjs").transform, false);
            enemy.transform.localPosition = new Vector3(300 + 200 * i, -360f, 0f);
            BattleManager.Instance.enemyList.Add(enemy);
            GameManager.Instance.BattleMode();
            BattleManager.Instance.isBattleEnd = false;
            ButtonManager.Instance.btn_EndTurn.SetActive(true);
        }
        Destroy(gameObject);
    }
}
