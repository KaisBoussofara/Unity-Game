using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Change_Level : MonoBehaviour
{ // Load Game over scene after death of ure Space Ship 
    [SerializeField] float CLevel = 0.5f;
    private IEnumerator coroutine; 
    private void OnTriggerEnter(Collider other)
    {
        coroutine = LoadScene(0.8f); // the coroutine will pause execution for 0.8 sec 
        // and automatically resume when the next scene is ready 
        StartCoroutine(coroutine); 
    }

    private IEnumerator LoadScene(float waitTime)  // ft of corotine who take arg the wait time to resume 
    {
        yield return new WaitForSeconds(waitTime); 
        SceneManager.LoadScene(2);
    }
}
