using UnityEngine;
using UnityEngine.InputSystem;

public class PointMe : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //get the mouse position
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        
        //work out the direction between our position and the mouse position
        //target position - transform.position
        Vector2 direction = mousePos - (Vector2)transform.position;
       
        //set our transform.up direction to equal that
        transform.up = direction;
    }
}
