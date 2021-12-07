using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFire : MonoBehaviour
{   public float Speed;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right* Speed * Time.deltaTime);

        if(transform.position.x > 12){
            Destroy(gameObject);
        }
    }
}
