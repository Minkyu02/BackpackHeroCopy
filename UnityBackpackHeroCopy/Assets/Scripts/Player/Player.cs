using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    public GameObject actionGameObject = null;
    private Animator playerAni = null;
    private Image playerHeart = null;
    private Text playerStatusText = null;
    private Text actionPoint = null;
    public Sprite[] statusImg = null;
    // Start is called before the first frame update
    void Start()
    {
        playerAni = transform.GetChild(0).GetComponent<Animator>();
        playerStatusText = transform.GetChild(2).GetChild(0).GetChild(1).GetChild(0).GetComponent<Text>();
        actionPoint = actionGameObject.transform.GetChild(0).GetComponent<Text>();
        playerHeart = transform.GetChild(2).GetChild(0).GetChild(1).GetComponent<Image>();
        PlayerManager.Instance.playerPos = this.transform.GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerManager.Instance.isAttacked)
        {
            playerAni.SetBool("attacked", true);
        }
        else
        {
            playerAni.SetBool("attacked", false);
        }
        PlayerAnimation();
        StatusCheck();
        actionPoint.text = $"{PlayerManager.Instance.playerActionPoint}";
    }
    private void StatusCheck()
    {
        if (PlayerManager.Instance.playerShieldRate > 0)
        {
            playerHeart.sprite = statusImg[1];
            playerStatusText.gameObject.SetActive(true);
            playerStatusText.text = $"{PlayerManager.Instance.playerShieldRate}";
        }
        else
        {
            playerHeart.sprite = statusImg[0];
            playerStatusText.gameObject.SetActive(false);
        }
    }

    private void PlayerAnimation()
    {
        BattleAni();
        RootingAni();
        WalkAni();
    }

    private void WalkAni()
    {
        if (PlayerManager.Instance.isWalk)
        {
            playerAni.SetBool("isWalk", true);
        }
        else
        {
            playerAni.SetBool("isWalk", false);
        }
    }
    private void BattleAni()
    {
        if (GameManager.Instance.battleMode)
        {
            playerAni.SetBool("battleMode", true);
        }
        else
        {
            playerAni.SetBool("battleMode", false);
        }
    }
    private void RootingAni()
    {
        if (GameManager.Instance.rootMode)
        {
            playerAni.SetBool("rootMode", true);
            if (PlayerManager.Instance.isMap)
            {
                playerAni.SetBool("isMap", true);
            }
            else
            {
                playerAni.SetBool("isMap", false);
            }
        }
        else
        {
            playerAni.SetBool("rootMode", false);
        }
    }
}
