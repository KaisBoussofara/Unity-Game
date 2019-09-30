using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Game"); // when u click on play load the gameScene
    }
    public void Quit()
    {
        Application.Quit(); // when u click on Quit  ---> exit the game
    }
   public void Setting()
    {
        SceneManager.LoadScene("Setings"); // when u click on Seting load the SettingsScene
    }


}
