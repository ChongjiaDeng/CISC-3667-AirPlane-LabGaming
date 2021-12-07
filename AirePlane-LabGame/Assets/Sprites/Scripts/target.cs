using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour
{   public float speed;
 public Transform target1;
    // Start is called before the first frame update
    void Start()
    {   
        target1 = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards( transform.position, target1.position, speed * Time.deltaTime);
    }
}
