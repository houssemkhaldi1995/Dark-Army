using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class openscene : MonoBehaviour {

    //public int nstage;
    float t;
	void Update ()
    {
        t += Time.deltaTime;
        if (t > 1.25f)
        {
            openstage();
        }
	}

    void openstage()
    {
       // Application.LoadLevel(nstage);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    

}
