using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public Rigidbody _rigidbody = null;

    public void BeingManipulated() 
    {
        _rigidbody.constraints = RigidbodyConstraints.None | RigidbodyConstraints.FreezeRotation | RigidbodyConstraints.FreezePositionZ;
        Debug.Log("MANIPULADA");
    }

    public void Freeze()
    {
        _rigidbody.constraints = RigidbodyConstraints.FreezeRotation | RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ;
        transform.parent = null;
        Debug.Log("PAREI");

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("FloorButton"))
        {
            Button button = other.gameObject.GetComponent<Button>();

            if (button != null)
            {
                button.Pressed();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("FloorButton"))
        {
            FloorButton button = other.gameObject.GetComponent<FloorButton>();

            if (button != null)
            {
                button.Unpressed();
            }
        }
    }
}
