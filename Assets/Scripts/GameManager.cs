using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //leave game by pressing esc
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit(); //Quit game
        }
    }
}
