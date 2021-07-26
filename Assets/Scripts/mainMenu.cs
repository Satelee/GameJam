using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public void PlayAction()
    {
        SceneManager.LoadScene("Level1");
    }

    public void QuitAction()
    {
        Application.Quit();
        print("Quitting");
    }
}
