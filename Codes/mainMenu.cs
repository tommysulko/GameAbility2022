using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
   public void PlayGame()
    {
        SceneManager.LoadScene(0);
    }

    public void exitGame()
    {
        Debug.Log("Your apllication is closeing");
        Application.Quit();
    }
}
