using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator anim;
    private MovementBehaviour mv;
    private Vector3 _dir,dir;
    private HealthBehavior HB;
    private Rigidbody2D _rb;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask groundLayer;
    private bool isGround;
    private PoolingManager2 PM;
    private Shoot SH;
    private Jump jp;
    private bool IsRight = true;
    public GameObject PointShoot;
    public float fireRate = 0.5F;
    private float nextFire = 0.0F;
   
    void Start()
    {
        anim = GetComponent<Animator>();
        mv = GetComponent<MovementBehaviour>();
        _rb = GetComponent<Rigidbody2D>();
        HB = GetComponent<HealthBehavior>();
        PM = GetComponent<PoolingManager2>();
        SH = GetComponent<Shoot>();
        jp = GetComponent<Jump>();
        
    }
  
    private void Update()
    {
        isGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
         _dir = new Vector3(InputManager.ip.movevalue,_rb.velocity.y,0);
        _dir.Normalize();
       mv.Move(_dir);
        if(HB.health<=0)
        {
           
            anim.SetTrigger("Death");
        }
       
        if (InputManager.ip.movevalue>0)
        {

            anim.SetTrigger("Run");
            Flip();
            if ((InputManager.ip.ShootValue > 0) && Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                anim.SetTrigger("Shoot");
                if (_dir == new Vector3(1, 0, 0))
                {

                    SH.Shoots(PointShoot.transform.position, _dir, PoolingManager2.Instance.GetPooledObject("bum"), PoolingManager2.Instance.GetPooledObject("ParticulaDisparar"));

                }
                else
                {
                    dir = new Vector3(1, 0, 0);
                    SH.Shoots(PointShoot.transform.position, dir, PoolingManager2.Instance.GetPooledObject("bum"), PoolingManager2.Instance.GetPooledObject("ParticulaDisparar"));
                    //anim.SetTrigger("Shoot");
                }
            }
        }
        if (InputManager.ip.movevalue <0)
        {

            anim.SetTrigger("Run");
            Flip();
            if ((InputManager.ip.ShootValue > 0) && Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                anim.SetTrigger("Shoot");
                if (_dir == new Vector3(-1, 0, 0))
                {

                    SH.Shoots(PointShoot.transform.position, _dir, PoolingManager2.Instance.GetPooledObject("bum"),PoolingManager2.Instance.GetPooledObject("ParticulaDisparar"));

                }
                else
                {
                    dir = new Vector3(-1, 0, 0);
                    SH.Shoots(PointShoot.transform.position, dir, PoolingManager2.Instance.GetPooledObject("bum"), PoolingManager2.Instance.GetPooledObject("ParticulaDisparar"));
                    //anim.SetTrigger("Shoot");
                }
            }
        }
        if (InputManager.ip.movevalue == 0)
        {

            anim.SetTrigger("Idle");
        }
        if ((InputManager.ip.Jumpvalue==1) && isGround)
        {

            jp.OnJump();
        }

        if ((InputManager.ip.ShootValue > 0) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            anim.SetTrigger("Shoot");
           
                    dir = new Vector3(1, 0, 0);
                SH.Shoots(PointShoot.transform.position, dir, PoolingManager2.Instance.GetPooledObject("bum"), PoolingManager2.Instance.GetPooledObject("ParticulaDisparar"));
             
            
        }
        
        if (Input.GetKeyDown(KeyCode.P))
        {

            anim.SetTrigger("Shoot");

            dir = new Vector3(1, 0, 0);
            SH.Shoots(PointShoot.transform.position, dir, PoolingManager2.Instance.GetPooledObject("cheto"), PoolingManager2.Instance.GetPooledObject("ParticulaDisparar"));
            Debug.Log("cheto");
            //anim.SetTrigger("Shoot");

        }
       
    
    }

    public void Stop()
    {
        mv.SetSpeed(0);
    }
   public void Flip()
    {

        IsRight = !IsRight;
        Vector3 localScale = transform.localScale;

        if(InputManager.ip.movevalue >0)
        {
            localScale.x = 1.5f;
            
        }
        if (InputManager.ip.movevalue <0)
        {

            localScale.x = -1.5f;
            
        }
        transform.localScale = localScale;
      

    }
}
