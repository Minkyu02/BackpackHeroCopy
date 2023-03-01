using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerManager.Instance.mapPlayerIcon = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerManager.Instance.isWalk)
        {
            if (PlayerManager.Instance.targetPos >= PlayerManager.Instance.mapPlayerPos)
            {
                // if (GameManager.Instance.playMaps[PlayerManager.Instance.targetPos]) 
                transform.position = Vector3.MoveTowards(transform.position, GameManager.Instance.playMaps[PlayerManager.Instance.mapPlayerPos + 1].position, Time.deltaTime * 3f);
                if (transform.position == GameManager.Instance.playMaps[PlayerManager.Instance.mapPlayerPos + 1].position)
                {
                    PlayerManager.Instance.mapPlayerPos++;
                }
                if (PlayerManager.Instance.mapPlayerPos == PlayerManager.Instance.targetPos)
                {
                    PlayerManager.Instance.isWalk = false;
                }
            }
            else
            {
                transform.position = Vector3.MoveTowards(transform.position, GameManager.Instance.playMaps[PlayerManager.Instance.mapPlayerPos - 1].position, Time.deltaTime * 3f);
                if (transform.position == GameManager.Instance.playMaps[PlayerManager.Instance.mapPlayerPos - 1].position)
                {
                    PlayerManager.Instance.mapPlayerPos--;
                }
                if (PlayerManager.Instance.mapPlayerPos == PlayerManager.Instance.targetPos)
                {
                    PlayerManager.Instance.isWalk = false;
                }
            }

            // transform.position = Vector3.MoveTowards(transform.position, PlayerManager.Instance.targetPos.position, Time.deltaTime);
            // if (transform.position == PlayerManager.Instance.targetPos.position) {
            //     PlayerManager.Instance.isWalk = false;
            // }
        }
    }
}
