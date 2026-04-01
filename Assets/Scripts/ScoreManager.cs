using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using TMPro; 

public class ScoreManager : MonoBehaviour
{
 
    public TextMeshProUGUI scoreText; 
    private float score;

    void Start()
    {
        
    }

    void Update()
    {
        if(GameObject.FindGameObjectWithTag("Player") != null){
            score += 1*Time.deltaTime;
            scoreText.text = ((int)score).ToString();
        }
    }
}