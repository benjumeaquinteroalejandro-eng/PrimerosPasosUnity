
using UnityEngine;

public class DinoRunner : MonoBehaviour
{

    [SerializeField] private float _force1 = 200f;

    [SerializeField] private float _velocity1 = 900f;

    [SerializeField] private Rigidbody2D _rigidbody2D1;

    [SerializeField] private GroundCheck _groundCheck1;
    // Start is called before the first frame update
    private void Awake()
    {
        _rigidbody2D1 = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {

    }

    private void Update()
    {
        if (_groundCheck1.isGround)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _rigidbody2D1.velocity = new Vector2(_rigidbody2D1.velocity.x, 0f);

                _rigidbody2D1.AddForce(Vector2.up * _force1, ForceMode2D.Impulse);

                Debug.Log("LOOK AT ME!!!");
            }

        }
        _rigidbody2D1.velocity = new Vector2(_velocity1, _rigidbody2D1.velocity.y);
    }
}
