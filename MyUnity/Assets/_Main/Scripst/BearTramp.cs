using UnityEngine;

public class BearTramp : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            DinoRunner jugador = collision.gameObject.GetComponent<DinoRunner>();
            if (jugador != null)
            {
                jugador.Morir();

                Destroy(jugador);
            }
        }
    }
}
