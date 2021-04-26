using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeTransparent : MonoBehaviour
{
    public float transparencyVal = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        Color newColor = GetComponent<Renderer>().material.color;
        newColor.a = transparencyVal;
        GetComponent<Renderer>().material.color = newColor;
    }


}
