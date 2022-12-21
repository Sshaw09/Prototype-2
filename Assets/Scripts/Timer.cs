using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    // The time in seconds that the timer will run for.
    public float duration = 8.0f;

    // The object to destroy when the timer finishes.
    public GameObject target;


    void Update()
    {
        // Decrement the timer by the amount of time that has passed since the last frame.
        duration -= Time.deltaTime;

        // If the timer has reached zero, destroy the target object.
        if (duration <= 0.0f)
        {
            Destroy(target);
        }

    }
}
