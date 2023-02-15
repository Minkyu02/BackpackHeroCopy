using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleButtons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Btn_Play()
    {
        Debug.Log("Play");
    }
    public void Btn_Quit()
    {
        Application.Quit();
    }
}
