using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDebug : MonoBehaviour
{
    // The tag of the object that we want to log a message when we collide with
    public string targetTag = "Player";

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collision object has the target tag
        if (collision.gameObject.tag == targetTag)
        {
            // Log the message to the debug console
            Debug.Log("Animal has hit the player");
        }
    }
}
