using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        SceneManager.LoadScene("02. GamePlay");
    }
    public void Btn_Quit()
    {
        Application.Quit();
    }
}
