﻿///////// Script Spawn Player pour Udemy //////////////////
///////////////////////////////////////////////////////////
////////  Instructeur Parein Jean-philippe ////////////////
///////////////////////////////////////////////////////////

using UnityEngine;
using System.Collections;

public class ScriptSpawn : MonoBehaviour {

    public AudioClip SoundDead;

   	void OnTriggerEnter (Collider Other)
    {
        if(Other.gameObject.name== "FPSController")
        {
            GetComponent<AudioSource> ().PlayOneShot (SoundDead);
            Other.gameObject.transform.position = GameObject.Find("SpawnPoint").transform.position;
            
        }	
	}		
}
