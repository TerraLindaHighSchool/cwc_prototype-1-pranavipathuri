using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject main; 
    private float laneSpace = 10f;
    private float currentLane = 0;
    private float xPos = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //Speed
    private float speed = 20.0f;
     
   // private float turnSpeed = 45.0f;
   // private float horizontalInput;
   // private float forwardInput;

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.A) && gameObject.transform.position.x > -5)
        {
            currentLane -= 10;
        }

        if(Input.GetKeyDown(KeyCode.D) && gameObject.transform.position.x < 5)
        {
            currentLane += 10;
            
        }
        if (xPos != currentLane)
        {
            xPos = Mathf.MoveTowards(xPos, currentLane, 20 * Time.deltaTime);
            
        }
        gameObject.transform.position = new Vector3(xPos, 0, 0);

        // Move the vehicle

        // horizontalInput = Input.GetAxis("Horizontal");
        // forwardInput = Input.GetAxis("Vertical");
        // Moves the car forward based on vertial input
        // transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Rotates the car based on horizontal input
        //  transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);

    }
}
