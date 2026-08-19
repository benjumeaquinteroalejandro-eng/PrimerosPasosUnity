
using UnityEngine;

public class DinoRunner : MonoBehaviour
{

    [SerializeField] private float _jumpforce = 200f;

    [SerializeField] private float _movementSpeed = 900f;

    [SerializeField] private Rigidbody2D _rigidbody2D1;

    [SerializeField] private GroundCheck _groundCheck1;

    [SerializeField] private Animator _animator;

    private bool _isDead = false;

    private void Awake()
    {
        _rigidbody2D1 = GetComponent<Rigidbody2D>();

        if (_animator == null)
            _animator = GetComponent<Animator>();
    }
    private void FixedUpdate()
    {

        _animator.SetBool("InGround", _groundCheck1.isGround);

        if (_groundCheck1.isGround)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                _rigidbody2D1.AddForce(Vector2.up * _jumpforce, ForceMode2D.Force);

                Debug.Log("LOOK AT ME!!!");
            }
        }
        _rigidbody2D1.velocity = new Vector2(1 * _movementSpeed, _rigidbody2D1.velocity.y);
    }

    public void Morir()
    {
        if (_isDead) return; 
        _isDead = true;
        _rigidbody2D1.velocity = Vector2.zero;

        _animator.SetTrigger("Death");
    }
}
