using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBehaviour : MonoBehaviour
{
    
    [SerializeField]
    public float velocity=30;
    Rigidbody2D _rb;
    public float jumpHeight;
    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    public void Move(Vector3 direction)
    {
          transform.position = transform.position + velocity * direction * Time.deltaTime;
    }
    public void Move(float vel, Vector3 dir)
    {
          transform.position = transform.position + vel * dir * Time.deltaTime;
    }
    public void MovePosition(Vector3 direction)
    {
          GetComponent<Rigidbody2D>().MovePosition(transform.position + velocity * direction * Time.deltaTime);
    }
    public void MoveRB(Vector3 direction)
    {
        if(_rb!=null)
        {
              _rb.velocity = direction* velocity;
        }
      }
    public float GetVelocity()
      {
          return velocity;
      }
    /*
    public void Move(Vector3 dir)
    {
        GetComponent<Rigidbody>().MovePosition(transform.position + speed * dir * Time.deltaTime);
        body.AddForce(-Physics.gravity, ForceMode.Acceleration);
        body.velocity = new Vector3(dir.x * speed, (dir.y+(-9.8f)*Time.deltaTime)*speed, dir.z*speed) ;
    }*/
    public void MoveToTarget(Vector3 _dir)
    {
        _rb.MovePosition(Vector3.MoveTowards(transform.position, _dir, velocity));
        _rb.velocity = _dir * velocity;
    }
    public float SetSpeed(int s)
    {
       return velocity = s;
    }
}
