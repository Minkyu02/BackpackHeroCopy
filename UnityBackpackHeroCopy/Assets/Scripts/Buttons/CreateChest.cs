using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class CreateChest : Road
{
    public GameObject chest = null;
    // Start is called before the first frame update

    protected override void Start()
    {
        base.Start();
        isEvent = true;
    }
    protected override void Update()
    {
        base.Update();
    }


    public override void OnPointerClick(PointerEventData eventData)
    {
        base.OnPointerClick(eventData);
    }

    protected override void AnyEvent()
    {
        base.AnyEvent();
        chest.SetActive(true);
        Destroy(gameObject);
    }
}
