using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{   public int index;

    public void playgame(){
        SceneManager.LoadScene("Scenes/Level0");
        index = PersistentData.Instance.GetIndex() + 1;
        PersistentData.Instance.SetIndex(index);
        
    }

    public void highscore(){

    }

    public void QuitGame(){
        Application.Quit();
    }
}
