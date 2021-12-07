using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bulletBar : MonoBehaviour
{
  public Slider slider;

    public void SetMaxBullet(int bullet){
        slider.maxValue = bullet;
        slider.value = bullet;
    }

    public void SetBullet(int bullet){
        slider.value = bullet;
    }
    // Start is called before the first frame update

}
