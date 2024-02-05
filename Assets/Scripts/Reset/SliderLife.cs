using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderLife : MonoBehaviour
{
    public Slider slider;
    private HealthBehavior hb;
    private void Start()
    {

        hb = GetComponent<HealthBehavior>();
        slider.value = 100;
    }
  public void SetSlider(Slider sl)
    {
        slider = sl;

    }
    public void SetMaxHealth(int health)
    {
        
        slider.value = health;
    }
    public void SetHealth (int health)
    {
        slider.value = health;
    }

   
}
