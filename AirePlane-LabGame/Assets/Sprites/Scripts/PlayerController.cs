using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{   public float speed;
    public GameObject bullet,explosion,dome,laser;
    // Start is called before the first frame update
    
    [SerializeField] private int maxHealth = 10;
    [SerializeField] private int maxBullet = 15;
    [SerializeField] private int maxDome = 2;
    public static int currentHealth;
    public  int currentBullet;
    public int currentDome;
    
    public GameObject lose;
    
    public healthBar healthBar;
    public bulletBar bulletBar;

    public domeBar domeBar;
    
    public bool IsOnItemS = false; 
    public bool IsOnItemL = false;
    private bool IsOnItemD= false;

    private Animator animator;


    public bool IsOnDome = false;
    private Vector3[] FiveFX={
       new Vector3(0,0,-30), new Vector3(0,0,-15), new Vector3(0,0,0), new Vector3(0,0,15), new Vector3(0,0,30)};
    void Start()
    {   

        animator = this.GetComponent<Animator>();

        //heal1.text = "HEALTH:" + heal.ToString();
        currentHealth = PersistentData.Instance.GetHealth();
        healthBar.SetMaxHealth(maxHealth);
        healthBar.SetHealth(PersistentData.Instance.GetHealth());

        currentBullet = maxBullet;
        bulletBar.SetMaxBullet(maxBullet);
        bulletBar.SetBullet(0);
        

        currentDome = maxDome;
        domeBar.SetMaxDome(currentDome);
        domeBar.SetDome(0);
    }

    // Update is called once per frame
    void Update()
    {   

        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");

        bool hasMoveH = !Mathf.Approximately(h, 0);
        bool hasMoveV = !Mathf.Approximately(v, 0);

        // check player if it walking and load animation iswalking.
        bool IsWalking = hasMoveH || hasMoveV;
        animator.SetBool("IsWalking", IsWalking);
            if (IsWalking)
        {


        Vector3  movement = transform.position + new Vector3(h, v, 0) * speed * Time.deltaTime;
        // game object allow to move as vertiacal and horzontal.
        PersistentData.Instance.SetHealth(currentHealth);

        if( movement.y>2.7f|| movement.y<-2.7f){
            movement.y = transform.position.y;
            // stop moving if the game object move out of the screen.
        }

        if( movement.x>13.0f|| movement.x<-5.6f){
            movement.x = transform.position.x;
            // stop moving if the game object move out of the screen.
        }

        transform.position = movement;}
        // new position of the game object.


        if(IsOnItemD && IsOnDome){
            dome.SetActive(true);
        }
         if(currentDome <= 0){
                 IsOnDome = false;
                 dome.SetActive(false);
             }

        if(Input.GetKeyDown(KeyCode.Space)){

            if(currentBullet > 0){
            
             
             if ( IsOnItemL){
                ShootingStyle("Laser");
                currentBullet--;
                callBullet();
            }
            else if (IsOnItemS){
                ShootingStyle("Shotgun");
                currentBullet--;
                callBullet();
            }
            else
            ShootingStyle("Normal");}

            else{
                ShootingStyle("Normal");
            }
        }

        
}
        private void lose1(){
            lose.SetActive(true);
            Time.timeScale = 0f;
        }
        private void callBullet(){
            bulletBar.SetBullet(currentBullet);
        }
        
         private void OnTriggerEnter2D(Collider2D collision){
            
            if(collision.tag=="EnemyBullet"){
            if(IsOnDome){
                currentDome--;
                soundManager.PlaySound("enemyShotting");
                domeBar.SetDome(currentDome);
                Destroy(collision.gameObject);
                
            }
            else{
                soundManager.PlaySound("enemyShotting");
            currentHealth--;
            healthBar.SetHealth(currentHealth);
            Destroy(collision.gameObject);

            if(currentHealth <= 0){
                Invoke("lose1", 2f);
                soundManager.PlaySound("explosion");
                Instantiate(explosion, transform.position, transform.rotation);
                gameObject.SetActive(false);
                }
            }
        }
            if(collision.tag=="Enemy"){
                if(IsOnDome){
                    
                currentDome--;
                domeBar.SetDome(currentDome);
                Destroy(collision.gameObject);
                
            }else{
            currentHealth--;
            healthBar.SetHealth(currentHealth);
            Destroy(collision.gameObject);
                soundManager.PlaySound("explosion");
                Instantiate(explosion, transform.position, transform.rotation);
                
                healthBar.SetHealth(currentHealth);
                if(currentHealth <= 0){
                Invoke("lose1", 2f);
                soundManager.PlaySound("explosion");
                Instantiate(explosion, transform.position, transform.rotation);
                gameObject.SetActive(false);}
                
            
            }
        } 

        if(collision.tag=="Boss"){
                if(IsOnDome){
                 soundManager.PlaySound("enemyShotting");
                currentDome--;
                domeBar.SetDome(currentDome);
                
            }else{
            currentHealth--;
            healthBar.SetHealth(currentHealth);
         
                soundManager.PlaySound("explosion");
                Instantiate(explosion, transform.position, transform.rotation);
                
                healthBar.SetHealth(currentHealth);
                if(currentHealth <= 0){
                Invoke("lose1", 2f);
                soundManager.PlaySound("explosion");
                Instantiate(explosion, transform.position, transform.rotation);
                gameObject.SetActive(false);}
                
            
            }
        } 



        if (collision.tag == "S"){
            soundManager.PlaySound("foley");
                currentBullet = 15;
                bulletBar.SetBullet(currentBullet);
                IsOnItemS = true;
                IsOnItemL = false;
                Destroy(collision.gameObject);
            }
        if (collision.tag == "D"){
            soundManager.PlaySound("foley");
                 IsOnDome =true;
                IsOnItemD = true;
                currentDome +=1;
                Destroy(collision.gameObject);
        }
        if (collision.tag == "L"){
                soundManager.PlaySound("foley");
                currentBullet = 8;
                bulletBar.SetBullet(currentBullet);
                IsOnItemL = true;
                IsOnItemS = false;
                Destroy(collision.gameObject);
            }

}

        public void ShootingStyle(string s){
            switch(s){
            case "Normal":
            soundManager.PlaySound("shotting");
            Instantiate(bullet, new Vector3 (transform.position.x+1, transform.position.y, transform.position.z), Quaternion.Euler(0,0,0));
            break;

            case "Laser":
            soundManager.PlaySound("laser");
            for(int i = 0; i< 6; i++){
            Instantiate(laser, new Vector3 (transform.position.x+1, transform.position.y+0.7f, transform.position.z), Quaternion.Euler(0,0,0));}
            break;

            case "Shotgun":
            soundManager.PlaySound("shotgun");
            for(int i = 0; i< 5; i++){
            Instantiate(bullet, new Vector3 (transform.position.x+1, transform.position.y, transform.position.z), Quaternion.Euler(FiveFX[i]));}
            break;

        }
        } 
}
