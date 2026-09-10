
using Unity.VisualScripting;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{

    [SerializeField] private UIManager _uiManager;
    [SerializeField] private int _puntosVida = 100;

    public void RestarVida(int daño)
    {
        _puntosVida = _puntosVida - daño;
    }
    public void OverHeal(int vida)
    {
        _puntosVida = _puntosVida + vida;
    }

    private void Update()
    {
        if (_puntosVida >= 80)
        {
            _uiManager.ColorBarra(Color.green);
        }
        if (_puntosVida >= 40 && _puntosVida < 80)
        {
            _uiManager.ColorBarra(Color.yellow);
        }
        if (_puntosVida >= 10 && _puntosVida < 40)
        {
            _uiManager.ColorBarra(Color.red);
        }
    }
}
