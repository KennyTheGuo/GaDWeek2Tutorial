using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleOnOrOff : MonoBehaviour
{
    public GameObject objectToToggle;

    public void start()
    {
        objectToToggle.SetActive(false);

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if(objectToToggle.active == false)
            {
                objectToToggle.SetActive(true);
            }
            else
            {
                objectToToggle.SetActive(false);
            }
        }
    }


}
