using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDebug : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Collision: " + col.gameObject.name);
    }

    void OnTriggerEnter(Collider col)
    {
        Debug.Log("Trigger: " + col.gameObject.name);
    }

}
