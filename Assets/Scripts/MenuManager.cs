
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour

{
    public GameObject settingsPanel;

    public void PlayGame()
    {
        Application.LoadLevel("Play");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void Se3ttingsPanel()
    {
        settingsPanel.SetActive(true);
    }

    public void Exit()
    {
        settingsPanel.SetActive(false);
    }
}
