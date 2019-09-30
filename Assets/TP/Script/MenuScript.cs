using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

	public void Quitter()
    {
       Application.Quit ();
    }

    public void Jouer()
    {
        SceneManager.LoadScene ("level1");
    }
}
