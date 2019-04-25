using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LivesScript : MonoBehaviour
{
    public GameObject heart1, heart2, heart3;
    public static int health;
    //private Animator animator = null;

    void Start()
    {
        //animator = GetComponent<Animator>();
        health = 3;
        heart1.gameObject.SetActive(true);
        heart2.gameObject.SetActive(true);
        heart3.gameObject.SetActive(true);

    }
    void Update()
    {
        if (health > 3)
            health = 3;

        switch (health)
        {
            case 3:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                //animator.Play("RedBorder");
                break;
            case 2:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(false);
                //animator.Play("RedBorder");
                break;
            case 1:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                //animator.Play("RedBorder");

                break;
            case 0:
                heart1.gameObject.SetActive(false);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                //animator.Play("RedBorder");
				GameOver();
                break;
        }

    }
	public void GameOver()
	{
		SceneManager.LoadScene("GameOver");
	}
    /*public static int livesValue = 10;
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
    }*/

    /*public static int livesValue = 10;
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
    }*/
}
