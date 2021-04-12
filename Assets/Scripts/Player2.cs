using UnityEngine;

public class Player2 : MonoBehaviour
{
    public Player1 player1 = null;
    public int playerIndex = 1;
    public float speed = 5.0f;
    public Rigidbody _rigidbody = null;
    public float jumpForce = 1.0f;
    public bool _jumping = false;
    public GameObject _camera1 = null;
    public GameObject _camera2 = null;

    void Update()
    {
        if (playerIndex == -1)
        {
            Vector3 direction = Vector3.zero;
            direction.x = Input.GetAxis("Horizontal");
            transform.position += direction * (speed * Time.deltaTime);
           
            if (Input.GetKeyUp(KeyCode.Alpha1))
            {
                ChangePlayer();
                Debug.Log("MUDEI PRO PLAYER 1");
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
        player1.playerIndex = 1;
        playerIndex = 1;
        _camera1.SetActive(true);
        _camera2.SetActive(false);
    }
}
