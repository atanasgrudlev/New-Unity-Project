using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour {


	public void Right ()
    {
       
        Score.scoreValue += 10;
    }

    public void Wrong()
    {
        Score.scoreValue -= 5;
        
    }
}
