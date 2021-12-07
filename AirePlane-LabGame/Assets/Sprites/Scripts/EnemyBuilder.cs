using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyBuilder : MonoBehaviour
{   public Transform Enemy, ItemD, ItemS, ItemL;
    public int diff, level;

    public bool setFalse = true;
    
    public int enemy;
    public int rangeD, rangeS, rangeL;

    

    // Start is called before the first frame update

    
    void Start()
    {           
        diff = PersistentData.Instance.GetDiff();

                level = PersistentData.Instance.GetIndex();

                if(level ==4){
                        setFalse  =false;
                }

                    if(PersistentData.Instance.GetDiff() == 3){
                        level +=1;
                        setFalse = true;
                    }

        
        
        enemy = diff*2;
        StartCoroutine(EnemyNumberator());
        if(diff == 2){
            StartCoroutine(EnemyNumberator());
        }

        if(diff == 3){
            StartCoroutine(EnemyNumberator());
            StartCoroutine(EnemyNumberator());
            StartCoroutine(EnemyNumberator());
            StartCoroutine(EnemyNumberator());
        }

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    IEnumerator EnemyNumberator(){

        while(setFalse){
            int d = Random.Range(0,5);
            int s = Random.Range(0,5);
            int l = Random.Range(0,5);
             rangeD = d;
             rangeS = s;
             rangeL = l;
            if(rangeD == 2){
            for (int i = 0; i<=1*diff; i++){
                Transform transform = Instantiate(ItemD);
                
                int n = Random.Range(-3, 4);
                transform.position = new Vector3(16,n,0);
                yield return new WaitForSeconds(1f);
                }
            }
            if(rangeS == 2){
            for (int i = 0; i<=1*diff; i++){
                Transform transform = Instantiate(ItemS);
                
                int n = Random.Range(-3, 4);
                transform.position = new Vector3(16,n,0);
                yield return new WaitForSeconds(1f);
                }
            }

            if(rangeL == 2){
            for (int i = 0; i<=1*diff; i++){
                Transform transform = Instantiate(ItemL);
                
                int n = Random.Range(-3, 4);
                transform.position = new Vector3(16,n,0);
                yield return new WaitForSeconds(1f);
                }

            }

            for(int i=0; i<enemy * diff; i++){
                Transform transform = Instantiate(Enemy);
                int n = Random.Range(-3, 4);
                transform.position = new Vector3(16,n,0);
                yield return new WaitForSeconds(1f);
                }
            
            yield return new WaitForSeconds(4f);
        }

        while(!setFalse){int d = Random.Range(0,5);
            int s = Random.Range(0,5);
            int l = Random.Range(0,5);
             rangeD = d;
             rangeS = s;
             rangeL = l;
            if(rangeD == 2){
            for (int i = 0; i<=1*diff; i++){
                Transform transform = Instantiate(ItemD);
                
                int n = Random.Range(-3, 4);
                transform.position = new Vector3(16,n,0);
                yield return new WaitForSeconds(1f);
                }
            }
            if(rangeS == 2){
            for (int i = 0; i<=1*diff; i++){
                Transform transform = Instantiate(ItemS);
                
                int n = Random.Range(-3, 4);
                transform.position = new Vector3(16,n,0);
                yield return new WaitForSeconds(1f);
                }
            }

            if(rangeL == 2){
            for (int i = 0; i<=1*diff; i++){
                Transform transform = Instantiate(ItemL);
                
                int n = Random.Range(-3, 4);
                transform.position = new Vector3(16,n,0);
                yield return new WaitForSeconds(1f);
                }

            }
            yield return new WaitForSeconds(4f);

    }
  }

  
}

