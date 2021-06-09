using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectColorChanger : MonoBehaviour
{
    public GameObject block;
    public float worked;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ChangeColor();
            worked++;
            if(worked > 3)
            {
                worked = 1;
            }
        }
    }

    void ChangeColor()
    {
        if (worked == 1)
        {
            block.GetComponent<Renderer>().material.color = Color.red;
        }
        if(worked == 2)
        {
            block.GetComponent<Renderer>().material.color = Color.blue;
        }
        if(worked == 3)
        {
            block.GetComponent<Renderer>().material.color = Color.green;
        }
    }
}
