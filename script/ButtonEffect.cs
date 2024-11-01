using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonEffect : MonoBehaviour,IPointerEnterHandler, IPointerExitHandler
{
    private Vector3 originalScale; // 원래 크기를 저장할 변수
    public float scaleMultiplier = 1.2f; // 커지는 배율

    void Start()
    {
        originalScale = transform.localScale; // 시작 시 원래 크기 저장
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("OnPointerEnter 호출됨");
        transform.localScale = originalScale * scaleMultiplier;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("OnPointerExit 호출됨");
        transform.localScale = originalScale;
    }
}
