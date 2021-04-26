using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        MoveObject();
        RotateObject();
    }

    void MoveObject()
    {
        transform.position = transform.position + new Vector3(speed * Time.deltaTime, speed * Time.deltaTime, 0f);
    }

    void RotateObject()
    {
        transform.Rotate(new Vector3(speed * Time.deltaTime, speed * Time.deltaTime, speed * Time.deltaTime));
    }
}
