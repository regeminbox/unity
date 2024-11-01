using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChange : MonoBehaviour
{
   public void changeScene(){
        Invoke("LoadMainScene",0.0f);
   }
   private void LoadMainScene(){
    SceneManager.LoadScene("Stage");
   }
}
