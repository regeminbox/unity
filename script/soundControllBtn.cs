using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class soundControllBtn : MonoBehaviour
{
    [SerializeField] private GameObject SoundControll;

    // Start is called before the first frame update
    public void ShowScon()
    {
        if(SoundControll!=null){
            Debug.Log("ShowScon호출됨");
            SoundControll.SetActive(true);
        }else{
            Debug.Log("설정이 안되어있습니다");
        }
    }

    public void HideSoundControll(){
        if(SoundControll != null){
            SoundControll.SetActive(false);
        }
    }



    
}
