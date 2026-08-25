using UnityEngine;

public class ObstaculoMortal : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D colision)
    {
        if (colision.gameObject.CompareTag("Player"))
        {
            Destroy(colision.gameObject);
        }
    }
}
