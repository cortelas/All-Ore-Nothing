using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	public float maxSpeed = 10f;
    public int numColor = 0;
    public Vector3 clickStart;
    public Rigidbody2D rb;

    // Throws box

    private void OnMouseDown()
    {
        clickStart = Input.mousePosition;
    }

    private void OnMouseUp()
    {
        rb.velocity =  Input.mousePosition - clickStart;
        // Limits Speed
        if(rb.velocity.magnitude > maxSpeed)
        {
            rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxSpeed);
        }
        Debug.Log("Velocity: " + rb.velocity + "    clickStart: " + clickStart + "  Input.mousePosition: " + Input.mousePosition);
    }


    // Use this for initialization
    void Start () {
        maxSpeed = 40;

        numColor = Random.Range(0, 6);
        // Assigns a color to the box
        switch (numColor)
        {
            case 5:
                this.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Purple Heart Gem Plain");
                break;
            case 4:
                this.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Orange Oval Gem Plain");
                break;
            case 3:
                this.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Red Circle Gem Plain");
                break;
            case 2:
                this.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("LightBlue Heart Gem Plain");
                break;
            case 1:
                this.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Green Teardrop Gem Plain");
                break;
            case 0:
                this.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Blue Square Gem Plain");
                break;
            default:
                this.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Blue Square Gem Plain");
                break;
        }
    }
	
	// Update is called once per frame
	void Update () {

        //Gets the world position of the mouse on the screen        
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //Checks whether the mouse is over the sprite
        bool overSprite = this.GetComponent<SpriteRenderer>().bounds.Contains(mousePosition);

        //If it's over the sprite
        if (overSprite)
        {
            //If we've pressed down on the mouse (or touched on the iphone)
            if (Input.GetButton("Fire1"))
            {
                //Debug.Log("moving");
                //Set the position to the mouse position
                this.transform.position = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x,
                    Camera.main.ScreenToWorldPoint(Input.mousePosition).y,
                    0.0f);
            }
        }

    }
}
