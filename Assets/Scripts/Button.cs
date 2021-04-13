using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject door = null;
    public bool isOpened = false;
    public bool isMoving = false;
    public float doorMaxHeight = 5.0f;
    public float doorMinHeight = 1.0f;

    private void Update()
    {
        if (isMoving == true)
        {
            if (isOpened == true)
            {
                door.transform.Translate(Vector3.down * Time.deltaTime * 5);
            }

            if (isOpened == false)
            {
                door.transform.Translate(Vector3.up * Time.deltaTime * 5);
            }
        }

        if (door.transform.position.y > doorMaxHeight)
        {
            door.transform.position = new Vector3(door.transform.position.x, doorMaxHeight, door.transform.position.z);
            isMoving = false;
            isOpened = true;
        }

        if (door.transform.position.y < doorMinHeight)
        {
            door.transform.position = new Vector3(door.transform.position.x, doorMinHeight, door.transform.position.z);
            isMoving = false;
            isOpened = false;
        }
     
    }

    public void Pressed()
    {
        if (isMoving == false)
        {
            isMoving = true;
        }
        
    }
}
