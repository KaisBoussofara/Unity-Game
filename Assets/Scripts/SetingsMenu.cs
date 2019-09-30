using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SetingsMenu : MonoBehaviour
{
    
    public void Apply()
    {
        SceneManager.LoadScene(0); // when you click on apply you return to  the main_menu
    }

    
}
