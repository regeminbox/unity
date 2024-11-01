using UnityEngine;

public class MuteAll : MonoBehaviour
{
    public AudioSource audioSource; // AudioSource를 Inspector에서 연결

    public void ToggleMuteStatus()
    {
        if (audioSource != null)
        {
            audioSource.mute = !audioSource.mute; // 뮤트 상태를 반전
            Debug.Log("오디오 뮤트 상태: " + audioSource.mute);
        }
        else
        {
            Debug.LogError("AudioSource가 설정되지 않았습니다.");
        }
    }
}
