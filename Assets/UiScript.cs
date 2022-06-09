using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiScript : MonoBehaviour
{
    public void QuitGame()
    {

    }

    public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
