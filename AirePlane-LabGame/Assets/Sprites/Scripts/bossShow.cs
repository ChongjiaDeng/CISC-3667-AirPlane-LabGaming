using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossShow : MonoBehaviour
{   public int second;    
public GameObject boss;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ExampleCoroutine());
    }

    // Update is called once per frame

       IEnumerator ExampleCoroutine(){
           yield return new WaitForSeconds(second);
        for(int i = 0; i <second; i++){
            boss.SetActive(false);
            yield return new WaitForSeconds(1);
            boss.SetActive(true);
        }

    }
}

