using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Makes it so that the animals and the bone get destroyed when they hit eachother. Need Collider & Rigidbody
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player has been hit");

        }
        else
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
       

    }
}
