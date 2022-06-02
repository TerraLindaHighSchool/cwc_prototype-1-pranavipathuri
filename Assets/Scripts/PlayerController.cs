using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public GameObject main; 
    private float laneSpace = 10f;
    private float currentLane = 0;
    private float xPos = 0;
    private int count = 0;
    public TextMeshProUGUI scoreText;
    public GameObject gameOverCanvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    //Speed
    private float speed = 20.0f;
     
   // private float turnSpeed = 45.0f;
   private float horizontalInput;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + count;
        if ((Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)) && currentLane > -5)
        {
            currentLane -= 10;
        }

        if((Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)) && currentLane < 5)
        {
            currentLane += 10;
            
        }
        if (xPos != currentLane)
        {
            xPos = Mathf.MoveTowards(xPos, currentLane, 20 * Time.deltaTime);
            
        }
        gameObject.transform.position = new Vector3(xPos, gameObject.transform.position.y, gameObject.transform.position.z);
        
        // Move the vehicle

        // forwardInput = Input.GetAxis("Vertical");
        // Moves the car forward based on vertial input

        // Rotates the car based on horizontal input
        //  transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("ENTERED");
        if (other.gameObject.CompareTag("PickUp"))
        {
            Destroy(other.gameObject);
            count++;
            //SetCountText();
        }
        else if(other.gameObject.CompareTag("Obstacle"))
        {
            gameOverCanvas.SetActive(true);
        }
    }
}
