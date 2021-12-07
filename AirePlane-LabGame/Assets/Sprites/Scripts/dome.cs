using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dome : MonoBehaviour
{   [SerializeField] private int maxDome = 10;
    public int currentDome;
    public domeBar domeBar;
    public Text dome1;
    public PlayerController PlayerController;

    // Start is called before the first frame update
    void Start()
    {
        currentDome = maxDome;
        domeBar.SetMaxDome(maxDome);
    }

    // Update is called once per frame
   private void OnTriggerEnter2D(Collider2D collision){
       if(collision.tag == "EnemyBullet"){
            currentDome--;
            Destroy(collision.gameObject);
            dome1.text = "Dome:";
            domeBar.SetDome(currentDome);
            if(currentDome == 0){
                
                soundManager.PlaySound("explosion");
                gameObject.SetActive(false);
               
            }
        }

       }
}
