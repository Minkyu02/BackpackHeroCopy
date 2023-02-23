using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    public GameObject actionGameObject = null;
    private Animator playerAni = null;
    private Text actionPoint = null;
    // Start is called before the first frame update
    void Start()
    {
        playerAni = transform.GetChild(0).GetComponent<Animator>();
        actionPoint = actionGameObject.transform.GetChild(0).GetComponent<Text>();
        PlayerManager.Instance.playerPos = this.transform;
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
        BattleAni();
        RootingAni();
        actionPoint.text = $"{PlayerManager.Instance.playerActionPoint}";
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
