using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UpgradeCount : MonoBehaviour
{
    private Text upgradeCount = null;
    // Start is called before the first frame update
    void Start()
    {
        upgradeCount = transform.GetChild(0).GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.upgradeCount == 0)
        {
            upgradeCount.text = "No more Upgrade";
        }
        else
        {
            upgradeCount.text = $"{GameManager.Instance.upgradeCount} Select";

        }
    }
}
