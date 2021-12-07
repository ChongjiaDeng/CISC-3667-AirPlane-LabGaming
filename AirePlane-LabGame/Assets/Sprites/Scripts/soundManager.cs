using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class soundManager : MonoBehaviour
{   public static AudioClip fireSound, explosionSound, enemyFireSound,laser,shotgun,Enemydie,foley;
    [SerializeField] Slider volumeSlider;
    static AudioSource audioSrc;
    public GameObject ObjectBgm;
    private AudioSource bgm;

    // Start is called before the first frame update
    void Start()
    {   
        if(!PlayerPrefs.HasKey("musicVolume")){
            PlayerPrefs.SetFloat("musicVolume", 1);
            Load();
            //check if it exists a value in player prefs. just load it. Otherwise, set volume to 100%.
        }
        else{
            Load();
        }
        
        ObjectBgm = GameObject.FindWithTag("bgm");
        bgm = ObjectBgm.GetComponent<AudioSource> ();

        fireSound = Resources.Load<AudioClip>("PlayerShoting");
        explosionSound = Resources.Load<AudioClip>("Explosion");
        enemyFireSound = Resources.Load<AudioClip>("EnemyShoting");
        laser = Resources.Load<AudioClip>("Laser"); 
        shotgun = Resources.Load<AudioClip>("GunShot"); 
        Enemydie = Resources.Load<AudioClip>("Wood");
        foley = Resources.Load<AudioClip>("GunCocking");
        
        audioSrc = GetComponent<AudioSource> ();
        // call file from the Resources folder.

    }

    void Update(){
        fireSound = Resources.Load<AudioClip>("PlayerShoting");
        explosionSound = Resources.Load<AudioClip>("Explosion");
        enemyFireSound = Resources.Load<AudioClip>("EnemyShoting");
        laser = Resources.Load<AudioClip>("Laser"); 
        shotgun = Resources.Load<AudioClip>("GunShot"); 
        Enemydie = Resources.Load<AudioClip>("Wood");
        foley = Resources.Load<AudioClip>("GunCocking");
        bgm.volume = AudioListener.volume;
        audioSrc = GetComponent<AudioSource> ();
    }

    // Update is called once per frame
    public void ChangeVolume(){
        AudioListener.volume = volumeSlider.value;
        Save();
        // If the player changes the volum level, saving the value.
    }
    private void Load(){
        volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
        //load value of volume if it already exists.
    }
    private void Save(){
        PlayerPrefs.SetFloat("musicVolume", volumeSlider.value); 
        //save volume to player prefs if it has changed.
    }

    public static void PlaySound(string clip)
    {   // swich case by name of files if they have called.
        switch(clip){
            case "shotting":
            audioSrc.PlayOneShot(fireSound);
            break;
            case "shotgun":
            audioSrc.PlayOneShot(shotgun);
            break;

             case "laser":
            audioSrc.PlayOneShot(laser);
            break;

            case "enemyShotting":
            audioSrc.PlayOneShot(enemyFireSound);
            break;

            case "explosion":
            audioSrc.PlayOneShot(explosionSound);
            break;

            case "enemyDie":
            audioSrc .PlayOneShot(Enemydie);
            break;

            case "foley":
            audioSrc .PlayOneShot(foley);
            break;

          
        }
    }
}
