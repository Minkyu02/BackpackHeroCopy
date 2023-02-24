using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerManager.Instance.mapPlayerPos = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerManager.Instance.isWalk)
        {
            transform.position = Vector3.MoveTowards(transform.position, PlayerManager.Instance.targetPos.position, Time.deltaTime);
            if (transform.position == PlayerManager.Instance.targetPos.position) {
                PlayerManager.Instance.isWalk = false;
            }
        }
    }
}
