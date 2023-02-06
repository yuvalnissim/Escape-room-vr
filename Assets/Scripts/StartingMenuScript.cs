using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingMenuScript : MonoBehaviour
{
   public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Exit Game");
    }
   public void StartGame()
   {
       //Initialize the game again
   }
}
