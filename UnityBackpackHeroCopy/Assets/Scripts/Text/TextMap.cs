using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextMap : TextBase
{

    private void OnEnable()
    {
        transform.localPosition = new Vector3(-1080f, 100f, 0f);
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= 0)
        {
            transform.Translate(Vector3.right * Time.deltaTime * 5f);
        }
    }
}
