using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Volume : MonoBehaviour
{   public GameObject VolumeMenuUI;
    // Start is called before the first frame update
    public static bool GameIsPaused = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        VolumeMenuUI.SetActive(true);
    }

         public void Resume(){
        VolumeMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
}

    public void Pasue(){
        VolumeMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

}
