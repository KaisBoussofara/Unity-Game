using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestructor : MonoBehaviour
{  // explosion destroyed 
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 5f); // destroy  the explosion after 5 sec 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
