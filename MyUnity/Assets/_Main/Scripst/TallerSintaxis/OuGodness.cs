using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OuGodness : MonoBehaviour
{
    [SerializeField] private PlayerStats _playerStats;
    private void OnCollisionEnter2D(Collision2D colision)
    {
        if (colision.gameObject.tag == "Player")
        {
            _playerStats.OverHeal(10);

            Destroy(this.gameObject);
        }
    }
}
