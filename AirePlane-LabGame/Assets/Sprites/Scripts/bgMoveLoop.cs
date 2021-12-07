using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgMoveLoop : MonoBehaviour
{   
    public float  widthSize;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if(transform.position.x< -widthSize){
            transform.position = new Vector2(widthSize*2, transform.position.y);
            // The background moves vertically. When the first background completes its movement.
            // it will move to the right, forming a loop.
        }
    }
}
