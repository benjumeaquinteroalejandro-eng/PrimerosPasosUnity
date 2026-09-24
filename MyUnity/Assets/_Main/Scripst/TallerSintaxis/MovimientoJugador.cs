using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    [SerializeField] private float _fuerzaSalto = 5f;
    [SerializeField] private float _velocidadMovimiento = 5f;
    [SerializeField] private Rigidbody2D _cuerpoRigido2D;
    [SerializeField] private DetectorSuelo _detectorSuelo;
    [SerializeField] private SpriteRenderer _spriteRenderer;

    private float _directionX = 0f;
    private void Awake()
    {
        _cuerpoRigido2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (_detectorSuelo.estaEnSuelo)
        {
            _directionX = 0f;

            if (Input.GetKey(KeyCode.Space))
            {
                _cuerpoRigido2D.AddForce(Vector2.up * _fuerzaSalto, ForceMode2D.Impulse);

                Debug.Log("Oprim� la tecla");
            }
            if (Input.GetKey(KeyCode.D))
            {
                _directionX = 1f;

                _spriteRenderer.flipX = false;

                Debug.Log("Camina");
            }
            if (Input.GetKey(KeyCode.A))
            {
                _directionX = -1f;

                _spriteRenderer.flipX = true;

                Debug.Log("Reversa");
            }
        }

        _cuerpoRigido2D.linearVelocity = new Vector2(_directionX * _velocidadMovimiento,_cuerpoRigido2D.linearVelocity.y);
    }
}
