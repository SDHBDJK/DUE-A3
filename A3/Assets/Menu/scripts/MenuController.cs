using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Student1Scene");
    }

    public void GoToOtherScenesMenu()
    {
        SceneManager.LoadScene("OtherScenesMenuScene");
    }

    public void LoadStudent1()
    {
        SceneManager.LoadScene("Student1Scene");
    }

    public void LoadStudent2()
    {
        SceneManager.LoadScene("Student2Scene");
    }

    public void LoadStudent3()
    {
        SceneManager.LoadScene("Student3Scene");
    }

    public void LoadStudent4()
    {
        SceneManager.LoadScene("Student4Scene");
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenuScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

