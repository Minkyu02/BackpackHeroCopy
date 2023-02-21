using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagUpgrade : MonoBehaviour
{
    public GameObject upgradeCountText = null;
    public GameObject upgradeFinBtn = null;
    public GameObject backpack = null;
    private InventoryUpgrade backpackUpgrade = null;
    // Start is called before the first frame update
    void Start()
    {
        backpackUpgrade = backpack.GetComponent<InventoryUpgrade>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Btn_Upgrade()
    {
        GameManager.Instance.isLevelup = true;
        while (true)
        {
            if (PlayerManager.Instance.playerExp < PlayerManager.Instance.playerNextExp)
            {
                break;
            }
            else
            {
                PlayerManager.Instance.playerExp -= PlayerManager.Instance.playerNextExp;
                PlayerManager.Instance.playerLevel++;
                PlayerManager.Instance.playerNextExp += 10;
            }
        }
        GameManager.Instance.upgradeCount = 4;
        GameManager.Instance.isLevelup = false;
        backpackUpgrade.isLevelup = true;
        transform.localScale = new Vector3(0.001f, 0.001f, 0.001f);
        upgradeFinBtn.transform.localScale = new Vector3(1f,1f,1f);
        upgradeCountText.transform.localScale = new Vector3(1f,1f,1f);
    }

    public void Btn_UpgradeFin()
    {
        PlayerManager.Instance.playerExp++;
        for (int i = 0; i < backpackUpgrade.backpackArray.Length; i++)
        {
            if (backpackUpgrade.backpackArray[i].GetComponent<InventoryBg>().isChoose)
            {
                backpackUpgrade.backpackArray[i].GetComponent<InventoryBg>().isActive = true;
            }
        }
        GameManager.Instance.upgradeCount = 0;
        backpackUpgrade.isLevelup = false;
        backpackUpgrade.NormalMode();
        transform.localScale = new Vector3(0.001f, 0.001f, 0.001f);
        upgradeCountText.transform.localScale = transform.localScale = new Vector3(0.001f, 0.001f, 0.001f);
    }
}
