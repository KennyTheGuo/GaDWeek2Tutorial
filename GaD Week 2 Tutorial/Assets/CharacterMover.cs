using UnityEngine;
using System.Collections;

public class CharacterMover : MonoBehaviour
{
    public float speed = 3.0F;
    public float rotateSpeed = 3.0F;

    CharacterController controller;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        
    }

    void Update()
    {



    }

    // Method that responds to collisions when character controller moving (not when stationary)
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        
    }
}