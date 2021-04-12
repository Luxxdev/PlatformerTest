using UnityEngine;

public class Player1 : MonoBehaviour
{
    public Player2 player2 = null;
    public int playerIndex = 1;
    public float speed = 5.0f;
    public Rigidbody _rigidbody = null;
    public float jumpForce = 1.0f;
    public bool _jumping = false;
    public GameObject _camera1 = null;
    public GameObject _camera2 = null;

    void Update()
    {
        if (playerIndex == 1)
        {
            Vector3 direction = Vector3.zero;
            direction.x = Input.GetAxis("Horizontal");
            transform.position += direction * (speed * Time.deltaTime);

            if (Input.GetKeyUp(KeyCode.Alpha2))
            {
                ChangePlayer();
                Debug.Log("MUDEI PRO PLAYER 2");
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Jump();
            }
        }
    }

    private void Jump()
    {
        _rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    void ChangePlayer()
    {
        player2.playerIndex = -1;
        playerIndex = -1;
        _camera1.SetActive(false);
        _camera2.SetActive(true);
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
