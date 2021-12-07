using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeIndex : MonoBehaviour
{   public static int  TimeLeftIndex = 0;
    // Start is called before the first frame update
    public Text time;

    public string playerName;
  
    public int score;
    public int index;
    public int diff;

    public int healthleft;
    public bool takingAway =false;


    void Start()
    {   playerName = PersistentData.Instance.GetName();
        score = PersistentData.Instance.GetScore();
        index = PersistentData.Instance.GetIndex();
        healthleft = PersistentData.Instance.GetHealth();
        diff = PersistentData.Instance.GetDiff();
        time = GetComponent<Text>();
        TimeLeftIndex = PersistentData.Instance.GetTime();
    }

    // Update is called once per frame
    void Update()
    {      TimeLeftIndex = PersistentData.Instance.GetTime();
            
             time.text = "TIME-LEFT:" + TimeLeftIndex;
             if(takingAway == false && TimeLeftIndex > 0){
                 StartCoroutine(TimerTake());
             }
             else{
                 takingAway = true;
             }
             
             if(takingAway == true && TimeLeftIndex ==0 && index == 1){
                 index ++;
                 PersistentData.Instance.SetName(playerName);
                 PersistentData.Instance.SetIndex(index);
                 healthleft = PlayerController.currentHealth;
                 PersistentData.Instance.SetHealth(healthleft);
                 PersistentData.Instance.SetDiff(diff);
                 TimeLeftIndex += 25;
                 PersistentData.Instance.SetTime(TimeLeftIndex);
                 score = GetData.playerScore* diff;
                 PersistentData.Instance.SetScore(score);
                 SceneManager.LoadScene("Scenes/Level1");

             }
             if(takingAway == true && TimeLeftIndex ==0 && index == 2){
                 
                 index ++;
                 PersistentData.Instance.SetName(playerName);
                 PersistentData.Instance.SetIndex(index);
                 PersistentData.Instance.SetHealth(healthleft);
                 PersistentData.Instance.SetDiff(diff);
                 TimeLeftIndex += 25;
                 PersistentData.Instance.SetTime(TimeLeftIndex);
                 score = GetData.playerScore * diff;
                 PersistentData.Instance.SetScore(score);
                 SceneManager.LoadScene("Scenes/Level2"); 
                // PersistentData.Instance.SetIndex(index);
             }
             if(takingAway == true && TimeLeftIndex ==0 && index == 3){
                 
                 index ++;
                 PersistentData.Instance.SetName(playerName);
                 PersistentData.Instance.SetIndex(index);
                 PersistentData.Instance.SetHealth(healthleft);
                 PersistentData.Instance.SetDiff(diff);
                 TimeLeftIndex += 999;
                 PersistentData.Instance.SetTime(TimeLeftIndex);
                 score = GetData.playerScore* diff;
                 PersistentData.Instance.SetScore(score);
                 SceneManager.LoadScene("Scenes/Level3"); 
                // PersistentData.Instance.SetIndex(index);
             }
             /*
             if(takingAway == true && TimeLeftIndex ==0 && index == 4){
                 
                 index ++;
                 PersistentData.Instance.SetName(playerName);
                 PersistentData.Instance.SetIndex(index);
                 PersistentData.Instance.SetHealth(healthleft);
                 PersistentData.Instance.SetDiff(diff);
                 TimeLeftIndex += 10;
                 PersistentData.Instance.SetTime(TimeLeftIndex);
                 score = GetData.playerScore* diff;
                 PersistentData.Instance.SetScore(score);
                 SceneManager.LoadScene("Scenes/Level3"); 
                // PersistentData.Instance.SetIndex(index);
             }
             */




        
    }

    IEnumerator TimerTake(){
            takingAway = true;
            yield return new WaitForSeconds(1);
            TimeLeftIndex --;
            PersistentData.Instance.SetTime(TimeLeftIndex);
            takingAway = false; 
    }
}

