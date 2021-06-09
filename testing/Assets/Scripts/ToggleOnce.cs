using System.Collections;   
using System.Collections.Generic;
using UnityEngine;

public class ToggleOnce : MonoBehaviour
{
    public GameObject objectToToggle;
    public bool StartOff;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Thing" || other.gameObject.tag == "Player" )
        {
            if (objectToToggle.active == false)
            {
                objectToToggle.SetActive(true);
            }

            else
            {
                objectToToggle.SetActive(false);
            }

            Destroy(this);
        }

    }

    private void Awake()
    { 
        if (StartOff)
        {
            objectToToggle.SetActive(false);
        }
    }


}
