using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
   public void PlayGame()
    {
        SceneManager.LoadScene(0);//creation of the game menù
    }

    public void exitGame()
    {
        //when we click exit, the closes
        Debug.Log("Your apllication is closeing");
        Application.Quit();
    }
}
