using UnityEngine;
using UnityEngine.InputSystem;

public class SpriteChanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color col;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //PickARandomColour();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Keyboard.current.anyKey.wasPressedThisFrame == true)
        //{
        //    //PickARandomColour();
        //}

        //NOT THIS ONE!!! spriteRenderer.sprite.bounds.Contains(mousePos) this is at (0, 0)
        //Use this one: spriteRenderer.bounds.Contains(mousePos) it's at the right position

        //get the mouse position
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        //is it over the sprite?
        if(spriteRenderer.bounds.Contains(mousePos) == true)
        {
            //Y: use the col variable
            spriteRenderer.color = col;
        }
        else
        {
            //N: set the colour to white
            spriteRenderer.color = Color.white;
        }

    }

    void PickARandomColour()
    {
        spriteRenderer.color = Random.ColorHSV();
    }
}
