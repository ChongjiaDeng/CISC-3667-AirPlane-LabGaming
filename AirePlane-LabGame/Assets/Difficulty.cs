using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Difficulty : MonoBehaviour
{   public int diff;
    // Start is called before the first frame update

    void Start(){
        diff = 0;

    }

    public void easy(){
        diff = 1;
        PersistentData.Instance.SetDiff(diff);
    }

    public void hard(){
        diff = 2 ;
        PersistentData.Instance.SetDiff(diff);
    }

    public void hell(){
        diff = 3 ;
        PersistentData.Instance.SetDiff(diff);
    }
}
