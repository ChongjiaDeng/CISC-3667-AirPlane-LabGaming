using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentData : MonoBehaviour
{
    [SerializeField] int playerScore;
    [SerializeField] string playerName;
    [SerializeField] int currentLevelIndex;

    [SerializeField] int currentTime;

    [SerializeField] int healthleft;

    [SerializeField] int diffLevel;



    
    
    


    public static PersistentData Instance; 

    // Start is called before the first frame update
    void Start()
    {   
        
        playerName = "";
        playerScore = 0;
        currentLevelIndex = 0;
        currentTime = 0;
    }

    private void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(this);
            Instance = this;
        }
        else
            Destroy(gameObject);
    }

    public void SetName(string n)
    {
        playerName = n;
    }

    public void SetScore(int s)
    {
        playerScore = s;
    }

    public string GetName()
    {
        return playerName;
    }

    public int GetScore()
    {
        return playerScore;
    }

    public void SetIndex(int i)
    {
        currentLevelIndex = i;
    }

    public int GetIndex()
    {
        return currentLevelIndex;
    }

    public void SetTime(int t){
        currentTime = t;
    }

    public int GetTime(){
        return currentTime;
    }

    public void SetHealth(int h){
            healthleft = h;
    }

    public int GetHealth(){
        return healthleft;
    }
    
    public int GetDiff(){
        return diffLevel;
    }
    public void SetDiff(int d){
        diffLevel = d;
    }

    // Update is called once per frame
    void Update()
    {

    }

    
}
