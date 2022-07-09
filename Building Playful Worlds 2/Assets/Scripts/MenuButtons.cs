using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ButtonSound()
    {
        FindObjectOfType<AudioManager>().Play("Button");
    }

    public void ReplayButton()
    {
        SceneManager.LoadScene("Title Screen");
    }

}
