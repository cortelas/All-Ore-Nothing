using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public int boxChoice = 0;

    // Destroys objects that collide with it
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Destroyed collided with " + collision.gameObject);

        if(collision.gameObject.GetComponent<SpriteRenderer>().sprite == Resources.Load<Sprite>("Black Box"))
        {
            ScoreScript.scoreValue += 200;
        }
        ScoreScript.scoreValue += 100;
        Destroy(collision.gameObject);
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
