using Unity.VisualScripting;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private int _puntosVida = 100;
    [SerializeField] private UIManager _uiManager;
    public void RestarVida(int daño)
    {
        _puntosVida = _puntosVida - daño;
    }

    public void SumarVida(int añadir)
    {
        _puntosVida = _puntosVida + añadir;
    }

    private void Update()
    {
        if (_puntosVida > 80)
        {
            _uiManager.ColorBarra(Color.green);
        }

        else if (_puntosVida >=40 && _puntosVida < 80)
        {
            _uiManager.ColorBarra(Color.yellow);
        }

        else if (_puntosVida < 40)
        {
            _uiManager.ColorBarra(Color.red);
        }
    }
}
