using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public int dmg;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
            other.gameObject.GetComponent<HealthBehavior>().Hurt(dmg);


    }
}
