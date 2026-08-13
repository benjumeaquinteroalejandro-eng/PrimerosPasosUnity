
using UnityEngine;

public class DinoRunner : MonoBehaviour
{

    [SerializeField] private float _jumpforce = 200f;

    [SerializeField] private float _movementSpeed = 900f;

    [SerializeField] private Rigidbody2D _rigidbody2D1;

    [SerializeField] private GroundCheck _groundCheck1;
    
    private void Awake()
    {
        _rigidbody2D1 = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {

    }

    private void FixedUpdate()
    {
        if (_groundCheck1.isGround)
        {
            if (Input.GetKey(KeyCode.W))
            {
                _rigidbody2D1.AddForce(Vector2.up * _jumpforce, ForceMode2D.Force);

                Debug.Log("LOOK AT ME!!!");
            }
            _rigidbody2D1.velocity = Vector2.right * _movementSpeed;
        }
    }
}
