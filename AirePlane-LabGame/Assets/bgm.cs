using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgm : MonoBehaviour
{
  
    private void Awake(){
        soundManager.PlaySound("bgm");

        DontDestroyOnLoad(this.gameObject);

        
    }


}
