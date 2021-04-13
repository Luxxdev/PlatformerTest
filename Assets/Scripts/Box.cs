using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public Rigidbody _rigidbody = null;
    void Update()
    {
        
    }

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

}
