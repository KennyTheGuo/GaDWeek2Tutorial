using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorOpening : MonoBehaviour
{

    [SerializeField] private int rayLength = 5;
    [SerializeField] private LayerMask layerMaskInteract;
    [SerializeField] private string excludeLayerName = null;

    private MyDoorController raycastedObj;

    [SerializeField] private KeyCode openDoorKey = KeyCode.Mouse0;

    [SerializeField] private Image Crosshair = null;
    private bool isCrosshairActive;
    private bool doOnce;
    private bool needsKey;
    private bool hasKey;

    private const string interactabletag = "Interactable";

    private void update()
    {
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        int mask = 1 << LayerMask.NameToLayer(excludeLayerName) | layerMaskInteract.value;

        if (Physics.Raycast(transform.position, fwd, out hit, rayLength, mask))
        {
            //if (hit.GetComponent<Collider>().CompareTag(interactabletag))
            if(hit.collider.CompareTag(interactabletag))
            {
                if (!doOnce)
                {
                    //raycastedObj = hit.GetComponent<Collider>().gameObject.GetComponent<MyDoorController>();
                    raycastedObj = hit.collider.gameObject.GetComponent<MyDoorController>();
                    CrosshairChange(true);
                }
            

                isCrosshairActive = true;
                doOnce = true;

                if (Input.GetKeyDown(openDoorKey))
                {
                    raycastedObj.PlayAnimation();
                }
            }
        }

        else
        {
            if(isCrosshairActive)
            {
                CrosshairChange(false);
                doOnce = false;

            }
        }
    }

    void CrosshairChange(bool on)
    {
        if (on && !doOnce)
        {
            Crosshair.color = Color.red;
        }
        else
        {
            Crosshair.color = Color.black;
            isCrosshairActive = false;
        }
    }
}
