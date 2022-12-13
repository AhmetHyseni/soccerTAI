using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_MainMenu : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject CreditsMenu;

    void Start()
    {
        MainMenuButton();
    }

    public void PlayNowButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game Mode");
    }

    public void PvPButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("P1 Vs P2");
    }

    public void AiButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Vs AI");
    }

    public void SettingsButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Settings");
    }
    
    public void BackButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
    }

    public void MainMenuButton()
    {
        MainMenu.SetActive(true);
        CreditsMenu.SetActive(false);
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
