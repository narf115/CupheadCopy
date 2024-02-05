using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HealthBehavior : MonoBehaviour
{
    [SerializeField]
    public int maxhealth=100;
    public int health;


    private SliderLife sl;
    public UnityEvent Die;
    void Start()
    {
        // health = maxhealth; 
        health = 100;
        sl = GetComponent<SliderLife>();
        
    }

    public void Hurt(int dmg)
    {
        health -= dmg;
        if (health <= 0)
        {
            Die.Invoke();
        }
    
        if(sl.enabled)
        {
            sl.SetHealth(health);
        }
       
    }

    public void SetHealth(int newhealth)
    {
        if (newhealth<=maxhealth)
        health = newhealth;
    }
    public int GetHealth()
    {
        return health;

    }
}
