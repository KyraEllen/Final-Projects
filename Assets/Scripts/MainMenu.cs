using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public int sceneToLoad; //Scene to Load

    public void QuitGame() // Quite Game
    {
        Application.Quit();Debug.Log("Quite Game"); //Print to console
    }
}
