using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class Bullet : MonoBehaviour
{
    Vector3 direction;
    public int velocity;
    MovementBehaviour mvb;
    public int dmg;
     GameObject fx  ;

    void Start()
    {
        mvb = GetComponent<MovementBehaviour>();
      fx = PoolingManager2.Instance.GetPooledObject("ParticulaFinal");

    }
    void Update()
    {
        mvb.Move(velocity, direction);
        
    }
    public void SetDirection(Vector3 dir) 
    {
        direction = dir;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
      
        PoolingManager2.Instance.GetPooledObject("ParticulaFinal");
        fx.transform.position = collision.transform.position;
        fx.transform.rotation = Quaternion.Euler(0, 0, 0);

        fx.SetActive(true);
    
       

        gameObject.SetActive(false);
        
        collision.gameObject.GetComponent<HealthBehavior>().Hurt(dmg);

    }
   
    private void OnBecameInvisible()
    {
        gameObject.SetActive(false); 
    }
}
