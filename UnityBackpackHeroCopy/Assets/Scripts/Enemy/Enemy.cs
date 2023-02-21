using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Enemy : MonoBehaviour, IPointerClickHandler
{
    public EnemyObjs enemyState = null;
    protected int maxHp = 0;
    protected int nowHp = 0;
    protected int attack = 0;
    public bool isSelect = false;
    protected virtual void Start()
    {
        maxHp = enemyState.eHp;
        nowHp = enemyState.eHp;

    }

    protected virtual void Update()
    {
        if (!isSelect)
        {
            transform.GetChild(0).gameObject.SetActive(false);
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        for (int i = 0; i < PlayerManager.Instance.enemyList.Count; i++)
        {
            PlayerManager.Instance.enemyList[i].GetComponent<Enemy>().isSelect = false;
        }
        isSelect = true;
        if (isSelect)
        {
            transform.GetChild(0).gameObject.SetActive(true);
        }
    }
}
