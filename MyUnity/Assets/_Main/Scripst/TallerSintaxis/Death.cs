using UnityEngine;

public class Death : MonoBehaviour
{
    [SerializeField] private UIManager _uiManager;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            _uiManager.RestarFillAmount(1F);
            Destroy(collision.gameObject);
        }
    }
}
