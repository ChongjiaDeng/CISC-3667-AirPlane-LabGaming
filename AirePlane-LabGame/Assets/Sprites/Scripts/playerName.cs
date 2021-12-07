using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerName : MonoBehaviour
{   [SerializeField] InputField input;

    public int diff;
     
    
    public GameObject inputField;
    // Start  is called before the first frame update
void Start(){

        diff = PersistentData.Instance.GetDiff();
}
    
    public void StoreName(){
        if(input.text != null){
        string playerName = input.text;
        PersistentData.Instance.SetName(playerName);
        PersistentData.Instance.SetTime(25);
        PersistentData.Instance.SetScore(0);
        PersistentData.Instance.SetHealth(10);
        PersistentData.Instance.SetDiff(diff);
        }

        else{
            PersistentData.Instance.SetName("Player");
            PersistentData.Instance.SetTime(25);
            PersistentData.Instance.SetScore(0);
            PersistentData.Instance.SetHealth(10);
            PersistentData.Instance.SetDiff(diff);
        }
    }

    }

