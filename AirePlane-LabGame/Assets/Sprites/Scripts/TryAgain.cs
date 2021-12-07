using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class TryAgain : MonoBehaviour
{   public string playerName;
    public int index;
    public int score;
    void Start(){
        playerName = PersistentData.Instance.GetName();
        score = PersistentData.Instance.GetScore();
        index = PersistentData.Instance.GetIndex();

    }
    
    public void Again(){
        if(index == 1){
            PersistentData.Instance.SetName(playerName);
                 PersistentData.Instance.SetIndex(index);
                 PersistentData.Instance.SetTime(30);
                 PersistentData.Instance.SetHealth(10);
                 score += GetData.playerScore;
                 PersistentData.Instance.SetScore(score);
                 Time.timeScale = 1f;
                SceneManager.LoadScene("Scenes/Level0");}

        else if(index == 2){
            PersistentData.Instance.SetIndex(index);
                 PersistentData.Instance.SetTime(30);
                 score += GetData.playerScore;
                 PersistentData.Instance.SetHealth(10);
                 PersistentData.Instance.SetScore(score);
                 Time.timeScale = 1f;
        SceneManager.LoadScene("Scenes/Level1");}

        else if(index == 3){
            PersistentData.Instance.SetIndex(index);
                 PersistentData.Instance.SetTime(30);
                 PersistentData.Instance.SetHealth(10);
                 score += GetData.playerScore;
                 PersistentData.Instance.SetScore(score);
                 Time.timeScale = 1f;
            SceneManager.LoadScene("Scenes/Level2");
            }

        else if (index == 4){
            PersistentData.Instance.SetIndex(index);
                 PersistentData.Instance.SetTime(30);
                 PersistentData.Instance.SetHealth(10);
                 score += GetData.playerScore;
                 PersistentData.Instance.SetScore(score);
                 Time.timeScale = 1f;
            SceneManager.LoadScene("Scenes/Level3");
        }
        else {
            Time.timeScale = 1f;
            SceneManager.LoadScene("Scenes/MainMenu");
        }

}
    public void MainMenu(){
        PersistentData.Instance.SetIndex(0);
        PersistentData.Instance.SetScore(0);
        PersistentData.Instance.SetHealth(0);
        PersistentData.Instance.SetDiff(0);
        Time.timeScale = 1f;
        Destroy(GameObject.FindWithTag("bgm"));
        SceneManager.LoadScene("Scenes/MainMenu");
    }

    public void Quit(){
        Application.Quit();
    }
}
