using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FireButton : MonoBehaviour
{
 public void SceneChage(){
    SceneManager.LoadScene("FireStage");
    Debug.Log("버튼 클릭");

 }
void Start(){

}
void Update(){

}


}
