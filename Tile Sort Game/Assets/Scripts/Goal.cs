using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public int boxChoice = 0;
    public static string leftTag;
    public static string rightTag;
    //Dont forget to update GEMCOUNT when adding new gems.
    const int GEMCOUNT = 6;


    public static bool[] GemSide =  new bool[GEMCOUNT];
    // Destroys objects that collide with it
    void OnTriggerEnter2D(Collider2D collision)
    {
        int GemIndex;
        Debug.Log("Destroyed collided with " + collision.gameObject);

        //Makes adding future gems to the system much easier.
        string GemType = collision.gameObject.GetComponent<SpriteRenderer>().sprite.name;
        switch (GemType)
        {
            case "Purple Heart Gem Plain":
                GemIndex = 0;
                break;
            case "Orange Oval Gem Plain":
                GemIndex = 1;
                break;
            case "Red Circle Gem Plain":
                GemIndex = 2;
                break;
            case "LightBlue Heart Gem Plain":
                GemIndex = 3;
                break;
            case "Green Teardrop Gem Plain":
                GemIndex = 4;
                break;
            case "Blue Square Gem Plain":
                GemIndex = 5;
                break;
            default:
                GemIndex = 0;
                break;
        }


        if (this.tag == leftTag)
        {
            //If its false add score, if its true subtract.
            if(!GemSide[GemIndex])
                ScoreScript.AddScore(200);
            else
                ScoreScript.SubtractScore(200);
        }
        else if (this.tag == rightTag)
        {
            if (GemSide[GemIndex])
                ScoreScript.AddScore(200);
            else
                ScoreScript.SubtractScore(200);

        }
        Destroy(collision.gameObject);
    }

    public static void GoalSwap()
    {
        for (int i = GEMCOUNT-1; i > 0; i--)
        {
            GemSide[i] = !GemSide[i];
        }
        //ToDo: Swap The Gem icons once they are implemented
    }
    
    public static void GemSideSwap(int GemIndex)
    {
        //Funtions Now
        if (GemSide[GemIndex])
            //False Goes Left
            GemSide[GemIndex] = false;
        else

            GemSide[GemIndex] = true;
    }
    // Start is called before the first frame update
    void Start()
    {
        leftTag = "leftGoal";
        rightTag = "rightGoal";
        for (int i = GEMCOUNT-1; i >= 0; i--)
        {
            if (i >= GEMCOUNT/2)
                //All Gems above half the count
                GemSide[i] = true;
            else
                //All Gems after Half the count.
                GemSide[i] = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
