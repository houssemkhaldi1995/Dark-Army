using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausemuni : MonoBehaviour {

    public GameObject menuobjet;
    // public Canvas interfac;
    public bool isActive = false;
    
  
	
	// Update is called once per frame
	void Update () {
        // menu is affiche
        if (isActive)
        {
            
            menuobjet.SetActive(true);
            //Cursor.visible = true;
           // Cursor.lockState = CursorLockMode.Confined;
            Time.timeScale = 0;
        }
        else
        {// menu non affichier
            menuobjet.SetActive(false);
           // Cursor.visible = false;
           // Cursor.lockState = CursorLockMode.Locked;
            Time.timeScale = 1;
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            Resumebutton();
        }



    }

  public  void Resumebutton()
    {
        isActive = !isActive;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Restart()
    {
        Application.LoadLevel(0);
    }
}
