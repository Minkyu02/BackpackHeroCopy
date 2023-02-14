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
    public GameObject test = null;
    // Start is called before the first frame update
    void Start()
    {
        image = gameObject.transform.GetChild(0).GetComponent<Image>();

    }

    // Update is called once per frame
    void Update()
    {
        if (isLeft && !isFin)
        {
            TopUi.transform.localPosition = TopUi.transform.localPosition + new Vector3(-1920f * Time.deltaTime * 3f, 0f, 0f);
            if (TopUi.transform.localPosition.x <= -1920f)
            {
                TopUi.transform.localPosition = new Vector3(-1920f,0f,0f);
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
        }
        else
        {
            isFin = false;
            isBag = true;
            isLeft = false;
            image.sprite = buttonImg[1];
        }
    }

    public void Btn_Upgrade() {
        test.GetComponent<InventoryUpgrade>().upgradeCount = 1;
        test.GetComponent<InventoryUpgrade>().isLevelup = true;
    }

    public void Btn_UpgradeFin() {
        test.GetComponent<InventoryUpgrade>().isLevelup = false;
        test.GetComponent<InventoryUpgrade>().NormalMode();
    }


}
