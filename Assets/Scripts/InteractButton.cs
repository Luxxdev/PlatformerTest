using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractButton : Button
{
    
    void Update()
    {
        if (isMoving == true)
        {
            if (isOpened == true)
            {
                interactable.transform.Translate(Vector3.down * Time.deltaTime * 5);
            }

            if (isOpened == false)
            {
                interactable.transform.Translate(Vector3.up * Time.deltaTime * 5);
            }
        }

        if (interactable.transform.position.y > MaxHeight)
        {
            interactable.transform.position = new Vector3(interactable.transform.position.x, MaxHeight, interactable.transform.position.z);
            isMoving = false;
            isOpened = true;
        }

        if (interactable.transform.position.y < MinHeight)
        {
            interactable.transform.position = new Vector3(interactable.transform.position.x, MinHeight, interactable.transform.position.z);
            isMoving = false;
            isOpened = false;
        }
     
    }

    public override void Pressed()
    {
        if (isMoving == false)
        {
            isMoving = true;
        }
    }
}
