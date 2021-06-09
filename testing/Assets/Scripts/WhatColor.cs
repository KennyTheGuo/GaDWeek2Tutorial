using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhatColor : MonoBehaviour
{
    public Color getObjectColor()
    {

        return GetComponent<Renderer>().material.color;
    }
}
