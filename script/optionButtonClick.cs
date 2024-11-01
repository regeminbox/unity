using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class optionButtonClick : MonoBehaviour
{
    [SerializeField] private GameObject PopupPanel; // 팝업 패널 오브젝트를 연결

    public void ShowPopup()
    {
        if (PopupPanel != null)
        {
            Debug.Log("ShowPopup 호출됨");
            PopupPanel.SetActive(true); // 패널을 활성화
        }else{
            Debug.Log("ShowPopup 설정이 안되어있습니다");
        }
    }

    public void HidePopup()
    {
        if (PopupPanel != null)
        {
            PopupPanel.SetActive(false); // 패널을 비활성화
        }
    }

    

}
