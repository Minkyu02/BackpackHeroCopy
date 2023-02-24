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
    public int block = 0;
    public int exp = 0;
    public int shieldRate = 0;
    public bool isSelect = false;
    public bool isAttack = false;
    public bool isAttackFin = true;
    public bool isDef = false;
    public bool isDefFin = true;
    public int enemyNext = 0; // 0 공격 1 방어 2 회복
    public Sprite[] enemyNowState = new Sprite[3]; // 0 하트 1 방패 2 힐
    private Image enemyNowStateImg = null;
    private Image enemyHpBar = null;
    private Text enemyHpText = null;
    private Text enemyAtkText = null;
    private Text enemyDefText = null;
    private Text enemyHealText = null;
    private Text enemyBlockText = null;
    protected virtual void Start()
    {
        enemyNowStateImg = transform.GetChild(2).GetChild(0).GetChild(1).GetComponent<Image>();
        enemyBlockText = transform.GetChild(2).GetChild(0).GetChild(1).GetChild(0).GetComponent<Text>();
        enemyAtkText = transform.GetChild(3).GetChild(0).GetChild(0).GetComponent<Text>();
        enemyDefText = transform.GetChild(3).GetChild(1).GetChild(0).GetComponent<Text>();
        enemyHealText = transform.GetChild(3).GetChild(2).GetChild(0).GetComponent<Text>();
        enemyHpBar = transform.GetChild(2).GetChild(0).GetComponent<Image>();
        enemyHpText = transform.GetChild(2).GetChild(0).GetChild(0).GetComponent<Text>();
        maxHp = enemyState.eHp;
        nowHp = enemyState.eHp;
        exp = enemyState.eExp;
        attack = enemyState.eAttack;
        block = enemyState.eBlock;
        healRate = enemyState.eHealRate;
        enemyAtkText.text = $"{attack}";
        enemyDefText.text = $"{block}";
        enemyHealText.text = $"{healRate}";
        NextBehavior();
    }

    protected virtual void Update()
    {
        Die();
        enemyHpBar.fillAmount = (float)nowHp / (float)maxHp;
        enemyHpText.text = $"{nowHp} / {maxHp}";
        if (!isSelect)
        {
            transform.GetChild(0).gameObject.SetActive(false);
        }
        AttackAni();
        DefAni();
        if (shieldRate > 0)
        {
            enemyNowStateImg.sprite = enemyNowState[1];
            enemyBlockText.gameObject.SetActive(true);
            enemyBlockText.text = $"{shieldRate}";
        }
        else
        {
            enemyNowStateImg.sprite = enemyNowState[0];
            enemyBlockText.gameObject.SetActive(false);
        }
    }

    private void AttackAni()
    {
        if (isAttack && isAttackFin)
        {
            transform.GetChild(1).Translate(Vector3.left * 5 * Time.deltaTime / 2);
        }
        else if (isAttack && !isAttackFin)
        {
            transform.GetChild(1).Translate(Vector3.right * 5 * Time.deltaTime / 2);
            if (transform.GetChild(1).transform.localPosition.x > -0.5f || transform.GetChild(1).transform.localPosition.x > 0.5f)
            {
                transform.GetChild(1).transform.localPosition = Vector2.zero;
            }
        }
    }


    private void DefAni()
    {
        if (isDef && isDefFin)
        {
            transform.GetChild(1).transform.localScale = new Vector3(transform.GetChild(1).transform.localScale.x, transform.GetChild(1).transform.localScale.y + Time.deltaTime, transform.GetChild(1).transform.localScale.z);
        }
        else if (isDef && !isDefFin)
        {
            transform.GetChild(1).transform.localScale = new Vector3(transform.GetChild(1).transform.localScale.x, transform.GetChild(1).transform.localScale.y - Time.deltaTime, transform.GetChild(1).transform.localScale.z);
        }
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

    protected void Die()
    {
        if (nowHp <= 0)
        {
            PlayerManager.Instance.playerExp += exp;
            BattleManager.Instance.enemyList.Remove(gameObject);
            Destroy(gameObject);
        }
    }


    protected void Attack()
    {
        isAttack = true;
        if (PlayerManager.Instance.playerShieldRate > 0)
        {
            PlayerManager.Instance.playerShieldRate -= attack;
            if (PlayerManager.Instance.playerShieldRate < 0)
            {
                PlayerManager.Instance.playerNowHp += PlayerManager.Instance.playerShieldRate;
            }
        }
        else
        {
           PlayerManager.Instance.playerNowHp -= attack;
        }
    }

    protected void Heal()
    {
        nowHp += healRate;
        if (nowHp > maxHp)
        {
            nowHp = maxHp;
        }
    }

    protected void Defence()
    {
        isDef = true;
        shieldRate = block;
    }

    public void Battle()
    {
        shieldRate = 0;
        switch (enemyNext)
        {
            case 0:
                Attack();
                transform.GetChild(3).GetChild(0).gameObject.SetActive(false);
                break;
            case 1:
                Defence();
                transform.GetChild(3).GetChild(1).gameObject.SetActive(false);
                break;
            case 2:
                Heal();
                transform.GetChild(3).GetChild(2).gameObject.SetActive(false);
                break;
        }
    }
    public void NextBehavior()
    {
        transform.GetChild(1).transform.localScale = new Vector3(1f, 1f, 1f);
        enemyNext = Random.Range(0, 3);
        switch (enemyNext)
        {
            case 0:
                transform.GetChild(3).GetChild(0).gameObject.SetActive(true);
                break;
            case 1:
                transform.GetChild(3).GetChild(1).gameObject.SetActive(true);
                break;
            case 2:
                transform.GetChild(3).GetChild(2).gameObject.SetActive(true);
                break;
        }
    }
}

