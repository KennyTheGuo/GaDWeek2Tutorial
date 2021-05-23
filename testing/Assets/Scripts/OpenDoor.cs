using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{

    private Animator doorAnim;
    public GameObject specificDoor;
    private bool doorOpen = false;


    private void awake()
    {

        doorAnim = gameObject.GetComponent<Animator>();

    }


    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {

            specificDoor.PlayAnimation();
            doorOpen = true;

        }

    }

}
