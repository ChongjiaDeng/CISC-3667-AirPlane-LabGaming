using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class domeBar : MonoBehaviour
{
   public Slider slider;

    public void SetMaxDome(int Dome){
        slider.maxValue = Dome;
        slider.value = Dome;
    }

    // Update is called once per frame
    public void SetDome(int Dome){
        slider.value = Dome;}
}
