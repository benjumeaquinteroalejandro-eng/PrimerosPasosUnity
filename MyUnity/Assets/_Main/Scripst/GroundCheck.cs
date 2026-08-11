using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public bool isGround;
    [SerializeField] private DinoRunner _dinoRunner;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        isGround = true;
        Debug.Log("WHO TOUCHED SASHA???");
    }

    // Update is called once per frame
    private void OnTriggerExit2D(Collider2D collisíon)
    {
        isGround = false;
        Debug.Log("Little Man");
    }
}
