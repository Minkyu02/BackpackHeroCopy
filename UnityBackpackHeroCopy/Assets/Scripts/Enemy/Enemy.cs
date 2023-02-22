using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Enemy : MonoBehaviour, IPointerClickHandler
{
    public EnemyObjs enemyState = null;
    public int maxHp = 0;
    public int nowHp = 0;
    public int attack = 0;
    public int healRate = 0;
    public int exp = 0;
    public bool isSelect = false;
    public int enemyNext = 0; // 0 공격 1 방어 2 회복
    private Image enemyHpBar = null;
    private Text enemyHpText = null;
    protected virtual void Start()
    {
        enemyHpBar = transform.GetChild(2).GetChild(0).GetComponent<Image>();
        enemyHpText = transform.GetChild(2).GetChild(0).GetChild(0).GetComponent<Text>();
        maxHp = enemyState.eHp;
        nowHp = enemyState.eHp;
        attack = enemyState.eAttack;
        exp = enemyState.eExp;
        NextBehavior();
        Debug.Log(enemyNext);
    }

    protected virtual void Update()
    {
        enemyHpBar.fillAmount = (float)nowHp / (float)maxHp;
        enemyHpText.text = $"{nowHp} / {maxHp}";
        if (!isSelect)
        {
            transform.GetChild(0).gameObject.SetActive(false);
        }
        Die();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        for (int i = 0; i < BattleManager.Instance.enemyList.Count; i++)
        {
            BattleManager.Instance.enemyList[i].GetComponent<Enemy>().isSelect = false;
        }
        isSelect = true;
        if (isSelect)
        {
            transform.GetChild(0).gameObject.SetActive(true);
        }
    }

    protected void Die() {
        if (nowHp <= 0) {
            PlayerManager.Instance.playerExp += exp;
            BattleManager.Instance.enemyList.Remove(gameObject);
            Destroy(gameObject);
        }
    }

    protected void Attack() {
        PlayerManager.Instance.playerNowHp -= attack;
    }

    protected void Heal() {
        nowHp += healRate;
        if (nowHp > maxHp) {
            nowHp = maxHp;
        }
    }

    protected void Defence() {


    }

    public void Battle() {
        switch (enemyNext) {
            case 0:
            Attack();
            break;
            case 1:
            Defence();
            break;
            case 2:
            Heal();
            break;
        }
        NextBehavior();
    }
    protected void NextBehavior() {
        enemyNext = Random.Range(0,3);
    }
}

