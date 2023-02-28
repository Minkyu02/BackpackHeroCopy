using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoTitle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameManager.Instance.dieScene = transform.parent.gameObject;
        transform.parent.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Btn_Title()
    {
        SceneManager.LoadScene("01. Title");
    }
}
