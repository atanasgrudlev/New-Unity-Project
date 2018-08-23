using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour {


	public void Right ()
    {
        //if(Input.GetKeyDown("Mouse 0"))
      //  {
      //      Destroy(gameObject) ;
        //}
        Score.scoreValue += 10;
    }

    public void Wrong()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
