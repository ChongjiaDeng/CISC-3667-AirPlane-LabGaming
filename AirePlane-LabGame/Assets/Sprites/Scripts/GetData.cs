using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GetData : MonoBehaviour
{   
    public static int  playerScore = 0;
    // Start is called before the first frame update
    public Text score;
    void Start()
    {   
       score = GetComponent<Text>();
       playerScore = PersistentData.Instance.GetScore();
       
       
    }

    // Update is called once per frame
    void Update()
    {   
        score.text = "SCORE:" + playerScore; 
    }


}
