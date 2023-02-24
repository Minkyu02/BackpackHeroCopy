using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Road : MonoBehaviour, IPointerClickHandler
{
    protected bool isClickEvent = false;
    protected bool isEvent = false;

    // Start is called before the first frame update
    protected virtual void Start()
    {

    }

    // Update is called once per frame
    protected virtual void Update()
    {
        MovePlayer();
    }

    public virtual void OnPointerClick(PointerEventData eventData)
    {
        if (!PlayerManager.Instance.isWalk && GameManager.Instance.rootMode)
        {
            PlayerManager.Instance.targetPos = GetComponent<RectTransform>();
            PlayerManager.Instance.isWalk = true;
            isClickEvent = true;
            // StartCoroutine(WalkDelay());
        }
    }

    // IEnumerator WalkDelay()
    // {
    //     PlayerManager.Instance.isWalk = true;
    //     yield return new WaitForSeconds(1.0f);
    //     PlayerManager.Instance.isWalk = false;
    //     isClickEvent = true;
    // }

    private void MovePlayer()
    {
        if (PlayerManager.Instance.isWalk)
        {
            if (PlayerManager.Instance.playerPos.localPosition.x > 0)
            {
            }
            else
            {
                PlayerManager.Instance.playerPos.Translate(Vector3.right * Time.deltaTime /5);

            }
        }
        else if (!PlayerManager.Instance.isWalk && isClickEvent && isEvent)
        {
            AnyEvent();
            PlayerManager.Instance.playerPos.localPosition = new Vector2(-600f, -390f);
        }
    }

    protected virtual void AnyEvent()
    {
        isClickEvent = false;
        ButtonManager.Instance.btn_SwapTop.GetComponent<IngameButtons>().Btn_Swap();
    }
}
