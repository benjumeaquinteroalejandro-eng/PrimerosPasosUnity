using UnityEngine;

public class Death : MonoBehaviour
{
    [SerializeField] private UIManager _uiManager;
    private void OnCollisionEnter2D(Collision2D colision)
    {
        if (colision.gameObject.tag == "Player")
        {
            _uiManager.RestarFillAmount(1F);
            Destroy(colision.gameObject);
        }
    }
}
