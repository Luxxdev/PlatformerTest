using UnityEngine;

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
                isHolding = true;
            }

            if (Input.GetKeyUp(KeyCode.E))
            {
                isHolding = false;
            }

            if (isHolding)
            {
                Debug.Log("TO SEGURANDO");
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

    public override void Interact()
    {

    }

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
