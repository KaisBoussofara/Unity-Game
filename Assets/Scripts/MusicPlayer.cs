using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class MusicPlayer : MonoBehaviour
{
    private void Awake()
    {
        int MusicOnPlay = FindObjectsOfType<MusicPlayer>().Length; // ta3mel table of Music Player  w tchouf length
        if (MusicOnPlay >1) // si il y'a plus q'un music dans la scene destroy it 
        {
            Destroy(gameObject);
        }
        else {
            DontDestroyOnLoad(gameObject); } // else let it  ; 
    }
    // Start is called before the first frame update
   
}
