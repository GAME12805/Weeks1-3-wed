using UnityEngine;
using UnityEngine.InputSystem;

public class Controls : MonoBehaviour
{
    public bool leftMouseIsPressed = false;
    public bool rightMouseIsPressed = false;
    public bool anyKeyIsPressed = false;

    public float speed = 3;
    public float rotationalSpeed = 100;

    public RotateMe rotateMe;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // mouse position: Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue())

        //isPressed is true all the time the button is pressed
        leftMouseIsPressed = Mouse.current.leftButton.isPressed;
        rightMouseIsPressed = Mouse.current.rightButton.isPressed;

        //wasPressedThisFrame is true the first frame the button is pressed only
        //wasReleasedThisFrame is true the first frame the button is released only
        if(Mouse.current.leftButton.wasPressedThisFrame == true)
        {
            Debug.Log("Left Button Pressed");

            rotateMe.speed *= -1; 
        }
        if (Mouse.current.rightButton.wasPressedThisFrame == true)
        {
            Debug.Log("Right Button Pressed");
        }

        anyKeyIsPressed = Keyboard.current.anyKey.isPressed;

        //test for left arrow key: move to the left
        if(Keyboard.current.leftArrowKey.isPressed == true)
        {
            Vector3 newRotation = transform.eulerAngles;
            newRotation.z += rotationalSpeed * Time.deltaTime;
            transform.eulerAngles = newRotation;
        }
        //test for right arrow key: move to the right
        if(Keyboard.current.rightArrowKey.isPressed == true)
        {
            Vector3 newRotation = transform.eulerAngles;
            newRotation.z -= rotationalSpeed * Time.deltaTime;
            transform.eulerAngles = newRotation;
        }
        //test for up arrow key: move up
        if (Keyboard.current.upArrowKey.isPressed == true)
        {
            transform.position += transform.up * speed * Time.deltaTime;
        }
        //test for down arrow key: move down
        if (Keyboard.current.downArrowKey.isPressed == true)
        {
            transform.position -= transform.up * speed * Time.deltaTime;
        }
    }
}
