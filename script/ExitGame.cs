using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour
{
    public void gameExit(){
        Debug.Log("ExitGame 호출됨");
        Application.Quit();

    }


}
