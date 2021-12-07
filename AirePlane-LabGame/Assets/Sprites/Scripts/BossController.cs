using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossController : MonoBehaviour
{   public float speed;
    public healthBar healthBar;
    public GameObject EnemyBullet,explosion;
    [SerializeField] private int maxHealth;

    public  static  int  currentHealth = 100;

    public int diff;

    

    // Start is called before the first frame update
    void Start()
    {   
        diff = PersistentData.Instance.GetDiff();
        maxHealth = maxHealth * diff;
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        StartCoroutine(BossShot());
        
    }

    // Update is called once per frame
    void Update()
    {   
        Vector3  movement = transform.position += new Vector3(0 ,speed * Time.deltaTime*-1 , 0);
        if( movement.y>2.3f){
            speed *= -1;
            // stop moving if the game object move out of the screen.
        }
        if(movement.y < -1.5f){
            speed *= -1;
        }
        transform.position = movement;

        GetBossHealth();

        
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.tag=="Bullet"){
            currentHealth--;
            soundManager.PlaySound("enemyDie");
            healthBar.SetHealth(currentHealth);
            if(currentHealth == 0){
            GetData.playerScore  += 1500;
            soundManager.PlaySound("explosion");
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(gameObject);}
        }
    }

     IEnumerator BossShot(){ 
         yield return new WaitForSeconds(5);
        while(true){
        
        
        soundManager.PlaySound("enemyShotting");
        Instantiate(EnemyBullet, new Vector3 (transform.position.x+1, transform.position.y, transform.position.z), Quaternion.Euler(0,0,0));
        
        yield return new WaitForSeconds(1);
        }
         
        }

        public static int  GetBossHealth(){
                return currentHealth;
        }

 }



