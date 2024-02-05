using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;
using UnityEngine.InputSystem.Controls;
using System;

public class InputManager : MonoBehaviour
{
    public static InputManager ip;
    private InputActions nc;
    public float movevalue;
    public float Jumpvalue;
    public float ShootValue;
    public float ResetValue;

    private void Start()
    {
        if (ip == null)
            ip = this;     
    }
    private void Awake()
    {
        nc = new InputActions();
       
        nc.Player.mov.performed += OnPlayerMove;
        nc.Player.mov.canceled += OnPlayerMove;
        nc.Player.Jump.performed += OnPlayerJump;
        nc.Player.Jump.canceled += OnPlayerJump;
        nc.Player.Shoot.started += OnPlayerShoot;
        nc.Player.Shoot.canceled += OnPlayerShoot;
        nc.Player.Reset.started += OnPlayerReset;
        nc.Player.Reset.canceled += OnPlayerReset;
    }

    private void OnPlayerReset(InputAction.CallbackContext cx)
    {
        ResetValue = cx.ReadValue<float>();
    }

    public void OnPlayerMove(InputAction.CallbackContext cx)
    {

        movevalue = cx.ReadValue<float>();

    }
    public void OnPlayerJump(InputAction.CallbackContext cx)
    {

        Jumpvalue = cx.ReadValue<float>();

    }
    public void OnPlayerShoot(InputAction.CallbackContext cx)
    {

        ShootValue = cx.ReadValue<float>();

    }
    private void OnEnable()
    {
         nc.Enable();
    }
     private void OnDisable()
     {
       nc.Disable();
      }
}
