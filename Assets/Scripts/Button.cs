using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Button : MonoBehaviour
{
    public GameObject interactable = null;
    public bool isOpened = false;
    public bool isMoving = false;
    public float MaxHeight = 5.0f;
    public float MinHeight = 1.0f;

    public abstract void Pressed();
    
}
