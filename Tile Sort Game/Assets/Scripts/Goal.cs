using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public int boxChoice = 0;
    public string leftTag;
    public string rightTag;
    
    // Destroys objects that collide with it
    void OnTriggerEnter2D(Collider2D collision)
    {
        int GemChoice;
        Debug.Log("Destroyed collided with " + collision.gameObject);

        /*if(collision.gameObject.GetComponent<SpriteRenderer>().sprite == Resources.Load<Sprite>("Black Box"))
        {
            ScoreScript.scoreValue += 200;
        }
        ScoreScript.scoreValue += 100;
        Destroy(collision.gameObject);
        */
        string GemType = collision.gameObject.GetComponent<SpriteRenderer>().sprite.name;
        switch (GemType)
        {
            case "Purple Heart Gem Plain":
                GemChoice = 0;
                break;
            case "Orange Oval Gem Plain":
                GemChoice = 1;
                break;
            case "Red Circle Gem Plain":
                GemChoice = 2;
                break;
            case "LightBlue Heart Gem Plain":
                GemChoice = 3;
                break;
            case "Green Teardrop Gem Plain":
                GemChoice = 4;
                break;
            case "Blue Square Gem Plain":
                GemChoice = 5;
                break;
            default:
                GemChoice = 0;
                break;
        }


        if (this.tag == leftTag)
        {
            switch(GemChoice)
            {
                case 0:
                    ScoreScript.scoreValue +=200;
                    Debug.Log("200 Points!");
                    break;
                case 1:
                    ScoreScript.scoreValue += 200;
                    Debug.Log("200 Points!");
                    break;
                case 2:
                    ScoreScript.scoreValue += 200;
                    Debug.Log("200 Points!");
                    break;
                case 3:
                    Debug.Log("Lost a Life... But Not Really");
                    break;
                case 4:
                    Debug.Log("Lost a Life... But Not Really");
                    break;
                case 5:
                    Debug.Log("Lost a Life... But Not Really");
                    break;
                default:
                    Debug.Log("Lost a Life... But Not Really");
                    break;
            }
        }
        else if (this.tag == rightTag)
        {
            switch (GemChoice)
            {
                case 5:
                    ScoreScript.scoreValue += 200;
                    Debug.Log("200 Points!");
                    break;
                case 4:
                    ScoreScript.scoreValue += 200;
                    Debug.Log("200 Points!");
                    break;
                case 3:
                    ScoreScript.scoreValue += 200;
                    Debug.Log("200 Points!");
                    break;
                case 2:
                    Debug.Log("Lost a Life... But Not Really");
                    break;
                case 1:
                    Debug.Log("Lost a Life... But Not Really");
                    break;
                case 0:
                    Debug.Log("Lost a Life... But Not Really");
                    break;
                default:
                    Debug.Log("Lost a Life... But Not Really");
                    break;
            }

        }
        else
        {
            Debug.Log("Lost a Life... But Not Really");
        }
        Destroy(collision.gameObject);
    }

    public void GoalSwap()
    {
        string temp;
        temp = leftTag;
        leftTag = rightTag;
        rightTag = temp;
        //ToDo: Swap The Gem icons once they are implemented
    }
    
    public void GemSideSwap()
    {
        //WIP
    }
    // Start is called before the first frame update
    void Start()
    {
        leftTag = "leftGoal";
        rightTag = "rightGoal";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
