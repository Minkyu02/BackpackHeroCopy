using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextBase : MonoBehaviour
{
    protected Text text = null;
    // Start is called before the first frame update
    protected virtual void Start()
    {
        text = GetComponent<Text>();
    }
    
}
