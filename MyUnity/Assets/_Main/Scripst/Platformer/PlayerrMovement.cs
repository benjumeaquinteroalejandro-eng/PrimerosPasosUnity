using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerrMovement : MonoBehaviour
{
    [SerializeField] private float _force = 200f;

    [SerializeField] private float _velocity = 900f;

    [SerializeField] private Rigidbody2D _rigidbody2D;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {

    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {

            _rigidbody2D.AddForce(Vector2.up * _force, ForceMode2D.Impulse);

        }

        _rigidbody2D.velocity = new Vector2(1 * _velocity, _rigidbody2D.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Plataform"))
        {
            Debug.Log("Game Over");
            Time.timeScale = 0f;
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#endif
            Application.Quit();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("FinalLine"))
        {
            Debug.Log("You Won");
            Time.timeScale = 0f;
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#endif
            Application.Quit();
        }
    }
}