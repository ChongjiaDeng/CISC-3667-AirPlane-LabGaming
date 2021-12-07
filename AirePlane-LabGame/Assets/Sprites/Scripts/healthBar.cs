using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthBar : MonoBehaviour
{   public Slider slider;

    public void SetMaxHealth(int health){
        slider.maxValue = health;
    }

    public void SetHealth(int health){
        slider.value = health;
    }
    // Start is called before the first frame update

}