using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    // public GameObject Bullet;
    //  public GameObject SFX;
    
    public void Shoots(Vector3 position, Vector3 direction,GameObject bullet, GameObject fxs)
    {
        
            float alfa = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            //GameObject bullet = PoolingManager2.Instance.GetPooledObject("bum");
            if (bullet != null)
            {
                bullet.transform.position = position;
                bullet.transform.rotation = Quaternion.Euler(0, 0, alfa);

                fxs.transform.position = position;
                fxs.transform.rotation = Quaternion.Euler(0, 0, alfa);

                bullet.SetActive(true);
                fxs.SetActive(true);

            }
            bullet.GetComponent<Bullet>().SetDirection(direction);
            PoolingManager2.Instance.GetPooledObject("ParticulaDisparar");
        
    }
  public void EnemyShoots (Vector3 position, Vector3 direction, GameObject bullet)
    {
        float alfa = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
      //  GameObject bullet = PoolingManager2.Instance.GetPooledObject("bumMalo");
        if (bullet != null)
        {
            bullet.transform.position = position;
            bullet.transform.rotation = Quaternion.Euler(0, 0, alfa);
            bullet.SetActive(true);

        }
        bullet.GetComponent<Bullet>().SetDirection(direction);

    }
    
}
