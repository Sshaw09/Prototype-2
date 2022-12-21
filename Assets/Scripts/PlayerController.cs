using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject projectilePrefab;

    public float horizontalInput;
    private float forwardInput;
    public float speed = 15.5f;
    public float xRange = 10.0f;
    public float bottomRange = -2f;
    public float topRange = 20f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Both if the IF statements prevent the player from moving out of bounds of the camera 
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.z < bottomRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, bottomRange);
        }

        //Movement on the Z axis, Horizontal (Left/Right)
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        //Movement on the Z axis, Vertical (Up/Down)
        forwardInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        //Makes so that when you click the space bar, the bone shoots out the character forward via the Z axis
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Launch a projectile from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
