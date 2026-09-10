
using UnityEngine;

public class BonusCloud : MonoBehaviour
{
    [SerializeField] private PlayerStats _playerStats;
    [SerializeField] private UIManager _uiManager;

    private void OnCollisionEnter2D(Collision2D colision)
    {
        if (colision.gameObject.CompareTag("Player"))
        {
            _playerStats.SumarVida(10);
            //necesitas sumar fill amount
            _uiManager.SumarFillAmount(0.1F);

            Destroy(this.gameObject);
        }
    }

}
