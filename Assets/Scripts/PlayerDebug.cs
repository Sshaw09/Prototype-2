using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDebug : MonoBehaviour
{
    // The tag of the object that we want to log a message when we collide with
    public string targetTag = "Player";

    public void OnTriggerEnter(Collider other)
    {
        if (gameObject.tag == targetTag)
        {
            Debug.Log("Player has been hit");
        }
    }
}
