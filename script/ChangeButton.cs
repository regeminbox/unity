using UnityEngine;
using UnityEngine.UI;

public class ChangeButton : MonoBehaviour
{
    public Button button;              // 버튼 컴포넌트
    public Sprite defaultImage;        // 기본 이미지
    public Sprite toggledImage;        // 변경될 이미지

    private bool isToggled = false;    // 토글 상태를 확인하는 변수
    private Image buttonImage;         // 버튼의 이미지 컴포넌트

    void Start()
    {
        buttonImage = button.GetComponent<Image>(); // 버튼의 Image 컴포넌트 가져오기
        buttonImage.sprite = defaultImage;          // 기본 이미지 설정
    }

    public void ToggleImage()
    {
        if (isToggled)
        {
            buttonImage.sprite = defaultImage;      // 원래 이미지로 돌아감
        }
        else
        {
            buttonImage.sprite = toggledImage;      // 다른 이미지로 변경
        }

        isToggled = !isToggled;                     // 토글 상태 전환
    }
}
