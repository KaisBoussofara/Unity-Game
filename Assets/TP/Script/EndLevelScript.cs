using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EndLevelScript : MonoBehaviour {

    public string LevelToLoad;
    public AudioClip SoundWin;

    void OnTriggerEnter (Collider Col) {

        if(Col.gameObject.tag == "Player")
        {
            StartCoroutine (LoadNextLevel ());
        }

    }

    IEnumerator LoadNextLevel ()
    {
        GetComponent<AudioSource> ().PlayOneShot (SoundWin);
        yield return new WaitForSeconds (3f);
        SceneManager.LoadScene (LevelToLoad);
    }
}
