using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAni : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FinAttack() {
        PlayerManager.Instance.isAttack = false;
    }

    public void FinAttacked() {
        PlayerManager.Instance.isAttacked = false;
    }
}
