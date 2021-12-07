using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgMove : MonoBehaviour
{   

    public float Speed;
    // allow to change bg moving speed;
    

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left* Speed * Time.deltaTime);
        //background moving as vertical, and it moves from the left to the right.

    }
}
