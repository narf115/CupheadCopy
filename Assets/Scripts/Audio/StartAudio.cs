using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAudio : MonoBehaviour
{

    public AudioManager AM;
    void Start()
    {
        AM.PlayMusic("Floral");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
