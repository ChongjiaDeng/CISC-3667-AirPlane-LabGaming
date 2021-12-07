using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserShot : MonoBehaviour
{   public int Speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
        {
        transform.Translate(Vector2.right* Speed * Time.deltaTime);

        if(transform.position.x >-1.5f){
                Speed +=2;
        }
        if(transform.position.x >1.5f){
                Speed +=2;
        }
        if(transform.position.x >2.5){
                Speed +=3;
        }
        if(transform.position.x >4.5f){
                Speed +=5;
        }
         if(transform.position.x >7){
                Destroy(gameObject);
        }
    }
}
