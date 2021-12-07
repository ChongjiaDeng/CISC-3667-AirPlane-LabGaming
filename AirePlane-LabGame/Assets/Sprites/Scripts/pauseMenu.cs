using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class pauseMenu : MonoBehaviour
{   // Start is called before the first frame update
    
    // check if game pasue
    public  GameObject pasueMenuUI;
    public  bool GameIsPaused = false;
    // Start is called before the first frame update
    void Start()
    {   
        
        pasueMenuUI.SetActive(false);
       
       
    }

    // Update is called once per frame
    void Update()
    {       
            

        if (Input.GetKeyDown(KeyCode.Escape)){
            if(GameIsPaused){
                Resume();
            }
            else{
                Pasue();
            }
        }
    }
     public  void Resume(){
        pasueMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
}
    public void Pasue(){
        pasueMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu(){
        PersistentData.Instance.SetIndex(0);
        PersistentData.Instance.SetScore(0);
        PersistentData.Instance.SetHealth(0);
        PersistentData.Instance.SetDiff(0);
        Time.timeScale = 1f;
        Destroy(GameObject.FindWithTag("bgm"));
        SceneManager.LoadScene("Scenes/MainMenu");
        
    }

    public void ExitGame(){
        Application.Quit();
    }
}
