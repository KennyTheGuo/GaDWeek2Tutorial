using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float vertmult;
    public float speed;
    public float horimult;
    public float rots;
    // Start is called before the first frame update
    void Update()
    {
        //moveobject();
        rotateobject();
    }

    // Update is called once per frame
    void moveobject()
    {
        transform.position = transform.position + new Vector3(speed * horimult * Time.deltaTime, speed * Time.deltaTime * vertmult, 0f);
    }

    void rotateobject()
    {
        transform.Rotate(new Vector3( 0f, 0f, rots * Time.deltaTime));
    }
}
