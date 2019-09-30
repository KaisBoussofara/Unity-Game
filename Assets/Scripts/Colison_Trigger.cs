using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
public class Colison_Trigger : MonoBehaviour
{
    [SerializeField] GameObject Explosion;
  

    private void OnTriggerEnter(Collider other)
    {
        Explosion.SetActive(true); //  active the specialEffect of explosion 
      
       
    }
   
      
       
  
    
}
