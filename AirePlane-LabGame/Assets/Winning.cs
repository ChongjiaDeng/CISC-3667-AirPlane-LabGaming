using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Winning : MonoBehaviour
{   public GameObject win;
        public string playerName;
  
    public int score;

    void Start(){
         playerName = PersistentData.Instance.GetName();
        score = PersistentData.Instance.GetScore();
    }

    void Update()
    {
         if(BossController.GetBossHealth() <= 0){
             win.SetActive(true);

    }
    }


    public void MainMenu(){
                 PersistentData.Instance.SetName(playerName);
                 PersistentData.Instance.SetIndex(0);
                 PersistentData.Instance.SetDiff(0);
                 score = GetData.playerScore;
                 PersistentData.Instance.SetScore(score);
                 Destroy(GameObject.FindWithTag("bgm"));
                 SceneManager.LoadScene("Scenes/MainMenu"); 
                  
        
    }
}
