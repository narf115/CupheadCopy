using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transparency : MonoBehaviour
{
    private SpriteRenderer _sp;
    public bool ChangeTransparency;
    public float T1, T2;
    // Start is called before the first frame update
    void Start()
    {
        _sp = GetComponent<SpriteRenderer>();
        ChangeTransparency = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (ChangeTransparency)
        {
            _sp.color = new Color(1f, 1f, 1f, T1);
            ChangeTransparency = false;
        }
        else
        {
            _sp.color = new Color(1f, 1f, 1f, T2);
            ChangeTransparency = true;
        }
    }
}
