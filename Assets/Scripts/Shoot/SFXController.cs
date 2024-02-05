using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXController : MonoBehaviour
{
    public void OnEnable()
    {
        Invoke("Destroy", 0.5f);
    }

    public void OnDisable()
    {

    }

    public void Destroy()
    {
        gameObject.SetActive(false);
    }
}
