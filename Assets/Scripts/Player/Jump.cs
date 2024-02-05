using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField] float JumpForce;
    Vector3 _dir;
    Rigidbody2D _rb;

    // Start is called before the first frame update
    void Start()
    {
        _dir = new Vector3(.0f, 1f, .0f);
        _rb = GetComponent<Rigidbody2D>();
    }

    
    public void OnJump()
    {
        _rb.AddForce(_dir * JumpForce);
        //_rb.velocity = new Vector2(_rb.velocity.x, jumpHeight);
    }
}
