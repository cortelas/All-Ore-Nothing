using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject Pausemenu, PauseButton;
    //private bool isPaused;

    public void Pause()
    {
        Pausemenu.SetActive(true);
        PauseButton.SetActive(false);
        Time.timeScale = 0;
    }

    public void Resume()
    {
        Pausemenu.SetActive(false);
        PauseButton.SetActive(true);
        Time.timeScale = 1;
    }
    public void MainMenu(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void Update()
    {
        if (Input.GetKeyDown("p"))
        {
            Pausemenu.gameObject.SetActive(!Pausemenu.gameObject.activeSelf);
            Pause();
        }
        /*if (Input.GetKeyDown("p"))
        {
          isPaused = !isPaused;
        }
        if (isPaused)
        {
            Pause();
        }
        else
        {
            Resume();
        }*/
    }
}
