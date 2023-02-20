using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleTonBase<T> : MonoBehaviour where T : MonoBehaviour
{

    private static T instance;

    public static T Instance
    {
        get
        {
            if (instance == null) {
                instance = (T)FindObjectOfType(typeof(T));

                if (instance == null) {
                    var singletonObject = new GameObject();
                    instance = singletonObject.AddComponent<T>();
                    singletonObject.name = typeof(T).ToString() + "(Singleton)";

                    DontDestroyOnLoad(singletonObject);
                }
            }
            return instance;
        }
    }

    protected virtual void Awake() {
        DontDestroyOnLoad(gameObject);
    }
    // Start is called before the first frame update
    protected virtual void Start()
    {

    }

    // Update is called once per frame
    protected virtual void Update()
    {

    }
}
