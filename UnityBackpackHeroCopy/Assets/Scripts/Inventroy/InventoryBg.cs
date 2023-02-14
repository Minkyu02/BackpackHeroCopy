using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class InventoryBg : MonoBehaviour, IPointerDownHandler
{
    public bool isActive = false;
    public bool isChoose = false;
    private Image image = null;
    public int index = 0;
    public int index_Y = 0;
    public int index_X = 0;
    public RectTransform rect = null;
    private InventoryUpgrade parents = null;
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
        parents = transform.parent.parent.GetComponent<InventoryUpgrade>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (isChoose) {
            isChoose = false;
        }else if (!isActive && !isChoose && parents.upgradeCount > 0)
        {
            parents.upgradeCount--;
            isActive = true;
            isChoose = true;
        }
    }

}
