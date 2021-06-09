using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public MyDoorController specificDoor;

    private void awake()
    {

    }


    public void Open()
    {
            specificDoor.PlayAnimation();
    }

}
