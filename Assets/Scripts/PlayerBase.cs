using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerBase : MonoBehaviour
{
    public Player1 player1 = null;
    public Player2 player2 = null;
    public int playerIndex = 1;
    public float speed = 5.0f;
    public float holdingSpeed = 1.0f;
    public float normalSpeed = 1.0f;
    public Rigidbody _rigidbody = null;
    public float jumpForce = 1.0f;
    public bool _jumping = false;
    public GameObject _camera1 = null;
    public GameObject _camera2 = null;
    public bool isHolding = false;
    public bool isInteracting = false;

    public abstract void Jump();


    public abstract void ChangePlayer();
    

    

    

    //    private void OnCollisionEnter(Collision other)
    //    {
    //        if (other.gameObject.CompareTag("Floor"))
    //        {
    //            RaycastHit hit = Physics.Raycast(transform.localPosition, 0.5f, Vector2.down, 1.0f, 1 << 8);
    //
    //            if (hit.collider == other.collider)
    //            {
    //              _jumping = false;
    //
    //            }
    //        }
    //    } //PROBLEMA
}

