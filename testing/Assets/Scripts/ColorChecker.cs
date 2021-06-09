using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChecker : MonoBehaviour
{
    public GameObject theWorld;
    public GameObject block1;
    public GameObject block2;
    private Color color1;
    private Color color2;

    void Start()
    {
        block1.GetComponent<Renderer>().material.color = Color.green;
        block2.GetComponent<Renderer>().material.color = Color.black;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (color1 == color2)
            {
                theWorld.SetActive(false);
            }
        }
        
    }

    void update()
    {
        color1 = block1.GetComponent<WhatColor>().getObjectColor();
        color2 = block1.GetComponent<WhatColor>().getObjectColor();
    }
}
