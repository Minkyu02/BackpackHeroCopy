using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagUpgradeFin : MonoBehaviour
{
    public GameObject backpack = null;
    private InventoryUpgrade backpackUpgrade = null;
    // Start is called before the first frame update
    void Start()
    {
        backpackUpgrade = backpack.GetComponent<InventoryUpgrade>();
        ButtonManager.Instance.btn_BagUpgradeFin = this.gameObject;
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Btn_UpgradeFin()
    {
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
        gameObject.SetActive(false);
        ButtonManager.Instance.btn_ItemCreate.SetActive(true);
    }
}
