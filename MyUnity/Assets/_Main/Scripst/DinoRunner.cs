
using UnityEngine;

public class DinoRunner : MonoBehaviour
{

    [SerializeField] private float _jumpforce = 200f;

    [SerializeField] private float _movementSpeed = 900f;

    [SerializeField] private Rigidbody2D _rigidbody2D1;

    [SerializeField] private GroundCheck _groundCheck1;

    private float _directionX = 0f;

    private void Awake()
    {
        _rigidbody2D1 = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        if (_groundCheck1.isGround)
        {
            _directionX = 0f;

            if (Input.GetKey(KeyCode.Space))
            {
                _rigidbody2D1.AddForce(Vector2.up * _jumpforce, ForceMode2D.Force);

                Debug.Log("LOOK AT ME!!!");
            }
            if (Input.GetKey(KeyCode.D))
            {
                _directionX = 1f;

                Debug.Log("INCOMIIIIIIING!!!");
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                _directionX = 1f;

                Debug.Log("INCOMIIIIIIING!!!");
            }
            if (Input.GetKey(KeyCode.A))
            {
                _directionX = -1f;

                Debug.Log("Let's go back");
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                _directionX = -1f;

                Debug.Log("Let's go back");
            }
            _rigidbody2D1.velocity = new Vector2(_directionX * _movementSpeed, _rigidbody2D1.velocity.y);
        }
    }
}
