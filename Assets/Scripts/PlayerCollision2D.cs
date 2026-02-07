using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision2D : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Collision with " + col.gameObject.name);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Trigger with " + col.gameObject.name);
    }
}

