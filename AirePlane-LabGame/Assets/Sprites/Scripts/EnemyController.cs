using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour
{   
    public float speed;
    public healthBar healthBar;
    public GameObject EnemyBullet,explosion;
    [SerializeField] private int maxHealth=3;
    public int currentHealth;
    // Start is called before the first frame update
    
    
    void Start()
    {   
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);

        int num = Random.Range(0, 9);
        if(num < 4){
        
        Instantiate(EnemyBullet, transform.position, Quaternion.Euler(0,0,0));
        //allow enemy shot bullet, and the shooting probability is 40%.
        }
    }

    // Update is called once per frame
    void Update()

    {  
        
        
        Vector3  movement = transform.position += new Vector3(speed * Time.deltaTime*-1 ,0 , 0);

        if( movement.x>19.0f|| movement.x<-9.0f){
            movement.x = 19.0f;
            // stop moving if the game object move out of the screen.
        }
        transform.position = movement;

        
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.tag=="Bullet"){
            currentHealth--;
            healthBar.SetHealth(currentHealth);
            if(currentHealth == 0){
            GetData.playerScore  += 10;
            soundManager.PlaySound("enemyDie");
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(gameObject);}
        }
    }

}
