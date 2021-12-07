using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warnning : MonoBehaviour
{   public int second;    
public GameObject warn;
    
    // Start is called before the first frame update
    
    void Start()
    {
       StartCoroutine(ExampleCoroutine());
    }



    IEnumerator ExampleCoroutine(){
        for(int i = 0; i <second; i++){
            warn.SetActive(true);
            yield return new WaitForSeconds(1);
            warn.SetActive(false);
        }

    }
}
