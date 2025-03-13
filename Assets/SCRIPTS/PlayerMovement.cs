using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    //we put information in the start of a class
    public float speed = 4.5f;
    public float jumpForce = 5f;
    public string hero = "Redd";
    
//xyz coordinates
    public Vector3 direction;
public Rigidbody playerRb;
    // always end in ;
    // do "" for name
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("my name is " + hero);

    }

    // Update is called once per frame
    //physics loop
    void FixedUpdate()
    {
        // the '.' is there to access the functionality of transform
        // ',' to seperate
        //transform.Translate(direction * Time.deltaTime *speed);
// Rigedbody is the proper way to connect physics to the player movement
Vector3 velocity = direction * speed;
velocity.y = playerRb.linearVelocity.y;
        playerRb.linearVelocity = velocity;
    }

//'{}' to define the function
    private void OnMove(InputValue value)
    {
        //asks the input system what keys ar being pressed
        Vector2 inputValue = value.Get<Vector2>();
        direction = new Vector3(inputValue.x, 0, inputValue.y);

    }

    private void OnJump(InputValue value)
    {
        //physics.raycast will cast a line that will hit other colliders,
        //if it finds another colider
        //is returns true if not it returns fals
        bool isGrounded =Physics.Raycast(transform.position, Vector3.down, 0.6f);
        if (isGrounded)
        { 
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
