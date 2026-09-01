
using UnityEngine;

public class PlayerStats : MonoBehaviour
{

    [SerializeField] private int _puntosVida = 100;

    public void RestarVida(int daño)
    {
        _puntosVida = _puntosVida - daño;
    }
}
