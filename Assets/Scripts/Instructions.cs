using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Instructions : MonoBehaviour {

    public void ToInstructions(string Howtoplay)
    {
        SceneManager.LoadScene(Howtoplay);
    }

    public void Back(string MenuScreen)
    {
        SceneManager.LoadScene(MenuScreen);
    }
}
