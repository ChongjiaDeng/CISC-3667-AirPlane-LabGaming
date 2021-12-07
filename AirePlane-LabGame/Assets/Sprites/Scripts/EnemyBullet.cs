using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{   public float speed;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {   
   
        Vector3  movement = transform.position += new Vector3(speed * Time.deltaTime*-1 ,0 , 0);
            if(transform.position.x <= -9){
            Destroy(gameObject);
        
      }
    }


}
