using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class CreateDoor : Road
{
    private void Awake()
    {
    }
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
        GameManager.Instance.nextStageDoor.SetActive(true);
        GameManager.Instance.playMaps[mapIndex].GetComponent<Road>().isHaveEvent = false;
        Destroy(gameObject);
    }
}
