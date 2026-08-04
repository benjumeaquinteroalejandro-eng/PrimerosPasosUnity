using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerrMovement : MonoBehaviour
{
    public float height = 1.84f;
    public int age = 30;
    public string nombree = "Alejo";
    public bool cantheyvote = true;

    public GameObject gameObject;
    public Rigidbody2D rigidbody2D;
    public Collider2D collider2D;
    public SpriteRenderer spriteRenderer;
    public Transform transform2D;

    private void Start()
    {
        Debug.Log("Hola: " + nombree + " tu edad es: " + age + " tu altura es: " + height);
        rigidbody2D.simulated = false;
        spriteRenderer.color = Color.red;
        transform2D.position = new Vector3(10f, 0f, 0f);
    }

    private void Update()
    {

    }
}
