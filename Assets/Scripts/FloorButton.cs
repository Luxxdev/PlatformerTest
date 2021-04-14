using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorButton : Button
{
    public bool playerOnButton = false;


    void Update()
    {
        if (playerOnButton == true)
        {
            if (isMoving == true)
            {
                if (isOpened == true)
                {
                    interactable.transform.Translate(Vector3.up * Time.deltaTime * 5);
                }
            }

        }

        if (playerOnButton == false)
        {
            if (isOpened == false)
            {
                if (isMoving)
                {
                    interactable.transform.Translate(Vector3.down * Time.deltaTime * 5);

                }
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
        Debug.Log("tofuncionando");
        playerOnButton = true;

        if(isOpened == false)
        {
            isMoving = true;
            isOpened = true;
        }
    }

    public void Unpressed()
    {
        isOpened = false;
        playerOnButton = false;
        isMoving = true;
    }

}