using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextStage : TextBase
{
    private bool fin = false;
    protected override void Awake()
    {
        base.Awake();
        GameManager.Instance.stageLoad = transform.parent.gameObject;
        GameManager.Instance.stageLoad.SetActive(false);
    }
    private void OnEnable()
    {
        transform.localPosition = new Vector3(1080f, -100f, 0f);
        text.text = $"{PlayerManager.Instance.PlayerFloor} OF 3 FLOOR";
        fin = false;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >= 0)
        {
            transform.Translate(Vector3.left * Time.deltaTime * 5f);
        }
        else
        {
            if (!fin)
            {
                StartCoroutine(Delay());
            }
        }
    }

    IEnumerator Delay()
    {
        fin = true;
        yield return new WaitForSeconds(1.0f);
        GameManager.Instance.stageLoad.SetActive(false);
    }
}
