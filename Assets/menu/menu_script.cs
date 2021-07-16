using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class menu_script : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene(2);
        Debug.Log("GO");
    }

    public void game_over()
    {
        SceneManager.LoadScene(1);
    }

    public void load_game()
    {
        
      //WIP basically load values from save text file
    }

    public void Return_menu()
    {
        SceneManager.LoadScene(0);
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
