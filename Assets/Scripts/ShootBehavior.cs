using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBehavior : MonoBehaviour
{
    public Weapon weaponCurrent;
    public Weapon[] weapons;
    private void Start()
    {
        weaponCurrent.Init();
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            weaponCurrent.Shoot();
        }
    }
}
