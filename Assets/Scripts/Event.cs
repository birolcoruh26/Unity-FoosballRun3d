using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Event : MonoBehaviour
{
   
    public void ReplayGame()
    {
        SceneManager.LoadScene(Application.loadedLevel);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void LoadNextLevel()
    {
        
          SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
       
    }
}
