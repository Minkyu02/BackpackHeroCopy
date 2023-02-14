using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Item : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    private RectTransform itemRect = null;
    private bool isSelect = false;
    Vector3 point = Vector3.zero;
    // Start is called before the first frame update
    protected virtual void Start()
    {
        itemRect = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        RotateItem();
        MousePoint();
    }

    protected void RotateItem()
    {
        if (Input.GetMouseButtonDown(1) && isSelect)
        {
            itemRect.rotation = itemRect.rotation * Quaternion.Euler(0, 0, 90);
        }
    }
    protected void MousePoint() {
        point = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, -Camera.main.transform.position.z));
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isSelect = true;
    }
    public void OnPointerUp(PointerEventData eventData) {
        isSelect = false;
    }
    public void OnDrag(PointerEventData eventData) {
        if (isSelect) {
            gameObject.transform.position = point; 
        }
    }
}
