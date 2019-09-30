using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Un_Controller : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        UnControle(); // when your SpaceShip die uncontrole it
    }
    private void UnControle()
    {
        SendMessage("OnDeath"); // send message va parsé tous le jeu en cherchant la procedure OnDeath 
        print("Control Frozen "); 
    }
}
