using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bosshealthBar : MonoBehaviour
{
    public GameObject Enemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        transform.position= new Vector3(Enemy.transform.position.x-5.1f,Enemy.transform.position.y-0.72f,0);

    }
}
