using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections.Generic;
public class ButtonSound : MonoBehaviour
{
    public AudioSource clickSound;

    public void ClickSound(){
        clickSound.Play();
    }

}
