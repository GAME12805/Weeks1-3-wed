using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpriteChanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color col;
    public List<Sprite> barrels;
    public int randomNumber;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //PickARandomColour();
        PickARandomSprite();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.anyKey.wasPressedThisFrame == true)
        {
            Debug.Log("Try to change the sprite");
            //PickARandomColour();
            if(barrels.Count > 0)
            {
                PickARandomSprite();
            }
            
        }

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

        if(Mouse.current.leftButton.wasPressedThisFrame == true && barrels.Count > 0)
        {
            barrels.RemoveAt(0);
        }
    }

    void PickARandomColour()
    {
        spriteRenderer.color = Random.ColorHSV();
    }

    void PickARandomSprite()
    {
        //get a random number between 0 and 2
        randomNumber = Random.Range(0, barrels.Count);
        //use that to set the sprite
        spriteRenderer.sprite = barrels[randomNumber];
    }
}
