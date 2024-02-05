using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Weapons/Weapon")]
public class Weapon : ScriptableObject
{
    [SerializeField]
    private int damage;

    private int CurrentAmmo;


    private float CurrentCooldown;

    [SerializeField]
    private int maxAmmo;

    [SerializeField]
    private float cadence;

    [SerializeField]
    private float maxCooldown;

    private void ShowWeapon()
    {
        Debug.Log($"Damage: {damage}\n CurrentAmmo :{CurrentAmmo}\n");

    }
    public void Init()
    {
        CurrentAmmo = maxAmmo;
        CurrentCooldown = maxCooldown;
    }
    public void Reload()
    {
        CurrentAmmo = maxAmmo;


    }
    public void Shoot()
    {
        CurrentAmmo--;
        CurrentCooldown = maxCooldown;
        ShowWeapon();
    }

    public void UpdateWeapon()
    {
        CurrentCooldown -= cadence;
        if (CurrentCooldown <= 0)
            CurrentCooldown -= cadence;
        else CurrentCooldown = 0; 
    }
}
