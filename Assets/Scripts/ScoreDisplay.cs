using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{ // Script attached to the text who is included into canvas 
    [SerializeField] int ScorePerHit; 
    int Score = 0;// initalise the score at 0 
    Text ScoreText ; // Attribut text of the score
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        ScoreText = GetComponent<Text>(); //text compenent 
        ScoreText.text = Score.ToString();// convertih en string 
    }

    public void ScoreRecord(int ScoreToInc)
    {
        Score = Score + ScoreToInc; //agumente score 
        ScoreText.text = Score.ToString(); // score .text = string + incrémentaion 
    }
}

