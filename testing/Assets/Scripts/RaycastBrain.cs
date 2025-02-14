using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastBrain : MonoBehaviour
{
    [SerializeField] private string selectableTag = "Selectable";
    [SerializeField] private string interactabletag = "Interactable";
    [SerializeField] private Material highlightMaterial;
    [SerializeField] private Material defaultMaterial;
    [SerializeField] private KeyCode openDoorKey = KeyCode.Mouse0;

    public OpenDoor raycastedObj;

    private Transform _selection;
    
    private void Update()
    {
        if (_selection != null)
        {
            var selectionRenderer = _selection.GetComponent<Renderer>();
            selectionRenderer.material = defaultMaterial;
            _selection = null;
        }
        
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            var selection = hit.transform;

            if (selection.CompareTag(selectableTag))
            {
                var selectionRenderer = selection.GetComponent<Renderer>();

                if (selectionRenderer != null)
                {
                    selectionRenderer.material = highlightMaterial;
                }

                _selection = selection;
            }

            if (selection.CompareTag(interactabletag))
            {
                raycastedObj = hit.collider.gameObject.GetComponent<OpenDoor>();
                Debug.Log("tagged");

                if (Input.GetKeyDown(openDoorKey))
                {
                    raycastedObj.Open();
                    Debug.Log("click");
                }
            }
        }

    }
}
