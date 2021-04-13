using UnityEngine;
using System;

public class Player1 : PlayerBase
{
    void FixedUpdate()
    {
        if (playerIndex == 1)
        {
            Vector3 direction = Vector3.zero;
            direction.x = Input.GetAxis("Horizontal");
            transform.position += direction * (speed * Time.deltaTime);

        }
    }

    void Update()
    {
        if (playerIndex == 1)
        {
            if (Input.GetKeyUp(KeyCode.Alpha2))
            {
                ChangePlayer();
                Debug.Log("MUDEI PRO PLAYER 2");
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Jump();
            }

            if (Input.GetKeyDown(KeyCode.E))
            {
                isInteracting = true;
                isHolding = true;
                isInteracting = false;
            }

            if (Input.GetKeyUp(KeyCode.E))
            {
                isHolding = false;
            }

        }
    }

    public override void Jump()
    {
        _rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    public override void ChangePlayer()
    {
        player2.playerIndex = -1;
        playerIndex = -1;
        _camera1.SetActive(false);
        _camera2.SetActive(true);
    }
    
    public void OnCollisionStay(Collision other)
    {
        if (other.gameObject.CompareTag("Box"))
        {
            Box box = other.gameObject.GetComponent<Box>();

            if (box != null)
            {
                if (_jumping == false)
                {
                    if (isHolding)
                    {
                        box.transform.SetParent(transformPlayer1);
                        box.BeingManipulated();
                    }

                    if (isHolding == false)
                    {
                        box.transform.parent = null;
                        box.Freeze();
                    }
                }
            }
        }
    }
   

//    private void OnCollisionEnter(Collision other)
//    {
//        if (other.gameObject.CompareTag("Floor"))
//        {
//           RaycastHit hit = Physics.Raycast(transform.localPosition, 0.5f, Vector3.down, 1.0f, 1 << 8);
//
//            if (hit.collider == other.collider)
//            {
//              _jumping = false;
//
//            }
//        }
//    } //PROBLEMA
}
