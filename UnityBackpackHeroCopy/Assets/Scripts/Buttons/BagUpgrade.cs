using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagUpgrade : MonoBehaviour
{
    public GameObject backpack = null;
    private InventoryUpgrade backpackUpgrade = null;
    // Start is called before the first frame update
    void Start()
    {
        backpackUpgrade = backpack.GetComponent<InventoryUpgrade>();
        ButtonManager.Instance.btn_BagUpgrade = this.gameObject;
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Btn_Upgrade()
    {
        PlayerManager.Instance.isLevelUp = false;
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
        backpackUpgrade.isLevelup = true;
        gameObject.SetActive(false);
        ButtonManager.Instance.btn_BagUpgradeFin.SetActive(true);
    }
}
