using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolling : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerManager.Instance.isWalk) {
            transform.Translate(Vector3.left * Time.deltaTime*2);
            if (transform.position.x <= -18) {
                transform.position = new Vector3(18f,0f,0f);
            }
        }

    }
}
