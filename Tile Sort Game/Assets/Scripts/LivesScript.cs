using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesScript : MonoBehaviour
{

    public static int livesValue = 10;
    static Text lives;

    // Start is called before the first frame update
    void Start()
    {
        lives = GetComponent<Text>();
    }

    public static void SubtractLife()
    {
        livesValue--;
        Debug.Log("Lost a Life.");
        UpdateLives();
    }

    public static void AddLife()
    {
        livesValue++;
        Debug.Log("Gained a Life!");
        UpdateLives();
    }

    public static void UpdateLives()
    {
        //Temporary, until Visual image representation implemented.
        lives.text = "Lives: " + livesValue;
    }
    // Update is called once per frame
    void Update()
    {
        //Doesnt need to be updated every frame.
        //lives.text = "Lives: " + livesValue;
    }
}
