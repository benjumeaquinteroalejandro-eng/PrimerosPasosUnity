using UnityEngine;

public class WinnerDetector : MonoBehaviour
{
    [SerializeField] private GameManager _gameManager;

    private void OnCollisionEnter2D(Collision2D colision)
    {
        if (colision.gameObject.CompareTag("Player"))
        {
            _gameManager.PausarJuego();
            _gameManager.playerwin();
           
        }
    }
}

