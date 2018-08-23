using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Timer2 : MonoBehaviour {

    private float timer = 60f;
    private Text timerSecound;
    // Use this for initialization
    void Start()
    {

        timerSecound = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        timerSecound.text = timer.ToString("Timer : 0");
        if (timer <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }
}


