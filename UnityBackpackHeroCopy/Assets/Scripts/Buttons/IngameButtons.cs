using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IngameButtons : MonoBehaviour
{
    public GameObject TopUi = null;
    private bool isBag = true;
    private bool isLeft = false;
    private bool isFin = true;
    [SerializeField]
    private Sprite[] buttonImg = null;
    private Image image = null;
    public GameObject backpack = null;
    private InventoryUpgrade backpackUpgrade = null;
    // Start is called before the first frame update
    void Start()
    {
        image = gameObject.transform.GetChild(0).GetComponent<Image>();
        if (backpack != null)
        {
            backpackUpgrade = backpack.GetComponent<InventoryUpgrade>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isLeft && !isFin)
        {
            TopUi.transform.localPosition = TopUi.transform.localPosition + new Vector3(-1920f * Time.deltaTime * 3f, 0f, 0f);
            if (TopUi.transform.localPosition.x <= -1920f)
            {
                TopUi.transform.localPosition = new Vector3(-1920f, 0f, 0f);
                isFin = true;
            }
        }
        else if (!isLeft && !isFin)
        {
            TopUi.transform.localPosition = TopUi.transform.localPosition + new Vector3(1920f * Time.deltaTime * 3f, 0f, 0f);
            if (TopUi.transform.localPosition.x >= 0)
            {
                TopUi.transform.localPosition = Vector3.zero;
                isFin = true;
            }
        }
    }

    public void Btn_Swap()
    {
        if (isBag)
        {
            isFin = false;
            isBag = false;
            isLeft = true;
            image.sprite = buttonImg[0];
            PlayerManager.Instance.isMap = true;
        }
        else
        {
            isFin = false;
            isBag = true;
            isLeft = false;
            image.sprite = buttonImg[1];
            PlayerManager.Instance.isMap = false;
        }
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
                PlayerManager.Instance.playerExp -=PlayerManager.Instance.playerNextExp;
                PlayerManager.Instance.playerLevel++;
                PlayerManager.Instance.playerNextExp += 10;
            }
        }
        GameManager.Instance.upgradeCount = 4;
        GameManager.Instance.isLevelup = false;
        backpackUpgrade.isLevelup = true;
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
    }


}
