using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OGodness : MonoBehaviour
{
    [SerializeField] private PlayerStats _playerStats;
    private void OnTriggerEnter2D(Collider2D colision)
    {
        if (colision.gameObject.tag == "Player")
        {
            _playerStats.OverHeal(10);

            Destroy(this.gameObject);
        }
    }
}
