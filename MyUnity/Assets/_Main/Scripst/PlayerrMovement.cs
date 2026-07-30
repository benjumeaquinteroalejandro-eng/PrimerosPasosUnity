using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerrMovement : MonoBehaviour
{

    //-
    //+
    //*
    // /

    // Variables
    [SerializeField] private int _edad = 17;
    [SerializeField] private float _velocidad = 15.5f;
    public string nombre = "Alejo";
    public bool isJumping = false;

    public float fuerza = 500f;
    public float fuerza2 = 100f;

    [SerializeField] private Rigidbody2D _rigidbody2D;


    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D.AddForce(Vector2.right * fuerza);
        _rigidbody2D.AddForce(Vector2.up * fuerza2);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
