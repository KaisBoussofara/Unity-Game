using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader  : MonoBehaviour
{
    void Start()
    {
        Invoke("LoadFirstScene", 2f); // You call Proc : LoadScene after 2sec ; 
    }
    void LoadFirstScene()
    {
        SceneManager.LoadScene(1); // load the scene of index nb 1 
    }

 }