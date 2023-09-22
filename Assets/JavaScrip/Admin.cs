using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Admin : MonoBehaviour
{
    public GameObject optionsPanel;

    public void OptionPanel() 
    {
        Time.timeScale = 0;
        optionsPanel.SetActive(true);
    }
    public void Return() 
    {
        Time.timeScale = 1;
        optionsPanel.SetActive(false);
    }

    public void GoMainMenu() 
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Star");
    }
    public void QuitGame()
    {
      
        Application.Quit();
    }

}
