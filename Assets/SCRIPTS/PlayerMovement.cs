using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    //we put information in the start of a class
    int health = 100;
    public float speed = 4.5f;
    public string hero = "Redd";

    public bool isAlive = true;
    public struct Tag(Player) = PlayerStartPosition;

//xyz coordinates
    public Vector3 direction;

    // always end in ;
    // do "" for name
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("my name is " + hero);

    }

    // Update is called once per frame
    void Update()
    {
        // the '.' is there to access the functionality of transform
        // ',' to seperate
        transform.Translate(direction * Time.deltaTime *speed);

    }

//'{}' to define the function
    private void OnMove(InputValue value)
    {
        //asks the input system what keys ar being pressed
        Vector2 inputValue = value.Get<Vector2>();
        direction = new Vector3(inputValue.x, 0, inputValue.y);

    }
}
