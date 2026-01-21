using UnityEngine;
using UnityEngine.InputSystem;

public class Rollover : MonoBehaviour
{
    public RotateMe rotateMe;
    public bool mouseIsOverMe = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //get the mouse position (in pixels) and convert it to world space (in meters)
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        //get the distance between transform.position and the mouse position
        float distance = Vector2.Distance(transform.position, mousePos);
        //if that distance is small (<1) then set mouseIsOverMe to true
        if(distance < 1)
        {
            mouseIsOverMe = true;
            rotateMe.speed = 0;
        }
        else
        {
            //otherwise set mouseIsOverMe to false
            mouseIsOverMe = false;
            rotateMe.speed = 100;
        }

    }
}
