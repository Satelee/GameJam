using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    [SerializeField] GameObject OptionsBlock;

    void Start()
    {
        OptionsBlock.SetActive(false);
    }

    public void PlayAction()
    {
        SceneManager.LoadScene("Level1");
    }

    public void OptionAction()
    {
        OptionsBlock.SetActive(true);
    }

    public void QuitAction()
    {
        Application.Quit();
        print("Quitting");
    }
}
