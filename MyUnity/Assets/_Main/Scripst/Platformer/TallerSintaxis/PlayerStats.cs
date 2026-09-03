using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private int _puntosVida = 100;
    public void RestarVida(int daño)
    {
        _puntosVida = _puntosVida - daño;
    }

    public void SumarVida(int añadir)
    {
        _puntosVida = _puntosVida + añadir;
    }

}
