﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour {
    
    public static int scoreValue = 0;
    Text score;

	// Use this for initialization
	void Start () {

        score = GetComponent<Text> ();
       
		
	}
	
	// Update is called once per frame
	void Update () {
        score.text = "Score: " + scoreValue;
        if (scoreValue >= 100)
        {
            SceneManager.LoadScene("End");
        }

    }
}
