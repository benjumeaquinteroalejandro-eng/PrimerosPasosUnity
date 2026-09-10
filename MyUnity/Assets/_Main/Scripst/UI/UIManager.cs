using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Image _barra;
    // Start is called before the first frame update
    public void SumarFillAmount(float amount)
    {
        _barra.fillAmount += amount;
    }

    public void RestarFillAmount(float amount)
    {
        _barra.fillAmount -= amount;
    }

    public void ColorBarra(Color color)
    {
        _barra.color = color;
    }
}