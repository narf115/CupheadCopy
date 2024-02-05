using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reset : MonoBehaviour
{
    public GameObject finalPanel, removeSlider1Ene, removeSlider2Pla,Player,Enemigo;
    public GameObject PrefabPlayer, PrefabEnemigo;
    public Slider SliderEn, SliderPla;
 
    bool a=false;
  
    public void Resetear()
    {
        Invoke("Reseteo", 1);
    }
    private void Update()
    {
        if ((InputManager.ip.ResetValue > 0) && a == true)
        {
            Debug.Log("sd");
            Next();
        }
    }
    public void Reseteo()
    {
        a = true;
        Player.SetActive(false);
        Enemigo.SetActive(false);
        finalPanel.SetActive(true);
        removeSlider1Ene.SetActive(false);
        removeSlider2Pla.SetActive(false);
        if ((InputManager.ip.ResetValue > 0))
        {
            
            Next();
        }
    }
    public void Next()
    {
       
        Instantiate(PrefabPlayer, new Vector3(-7.9f,-2.5f, 0), Quaternion.identity);
        Instantiate(PrefabEnemigo, new Vector3(5.24f,0.56f, 0), Quaternion.identity);
        //  PrefabPlayer.GetComponent<HealthBehavior>().Die();
        removeSlider1Ene.SetActive(true);
        removeSlider2Pla.SetActive(true);
        SliderEn.value = 100;
        SliderPla.value = 100;
        PrefabPlayer.GetComponent<SliderLife>().SetSlider(SliderPla);
        PrefabEnemigo.GetComponent<SliderLife>().SetSlider(SliderEn);
       // PrefabPlayer.GetComponent<HealthBehavior>() = GameObject.Find("PlayerOr").GetComponent<HealthBehavior>();
        finalPanel.SetActive(false);
        a = false;
       
    }
    
    public void NextTo(GameObject Player,GameObject Boss,GameObject SliderEne, GameObject SliderPlayer)
    {
        a = true;
       
        Player.SetActive(false);
        Boss.SetActive(false);
        finalPanel.SetActive(true);
        SliderEne.SetActive(false);
        SliderPlayer.SetActive(false);
        if ((InputManager.ip.ResetValue > 0) && a == true)
        {
            Next();
        }
    }
}
