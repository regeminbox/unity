using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManger : MonoBehaviour
{

    public AudioSource bgm;

    // Start is called before the first frame update
    void Start()
    {
        if(bgm !=null){
        bgm.loop =true;    
        bgm.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
