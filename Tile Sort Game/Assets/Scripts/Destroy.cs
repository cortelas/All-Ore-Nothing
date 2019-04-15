using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{

    // Destroys objects that collide with it
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Destroyed collided with " + collision.gameObject);
        Destroy(collision.gameObject);

        /*if (this.tag == "goalLeft")
        { //Unsure as how to handle swapping these values later
            if(collision.GetComponent<SpriteRenderer>().sprite == Resources.Load<Sprite>("Purple Heart Gem Plain"))
            { // If its a purple gem... There has to be a more effective way to do this
                Debug.Log("Purple Gem Sent to Left Goal");
            }
        }*/
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
