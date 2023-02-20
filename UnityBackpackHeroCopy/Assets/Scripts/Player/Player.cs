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
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerManager.Instance.isMap) {
            playerAni.SetBool("isMap", true);
        }
        else {
            playerAni.SetBool("isMap", false);
        }
        actionPoint.text = $"{PlayerManager.Instance.playerActionPoint}";

    }
}
