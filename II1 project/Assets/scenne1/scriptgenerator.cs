using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class scriptgenerator : MonoBehaviour {

  
    

    public void OpenScene (int scennumb )
    {
       // Invoke("openstage", 1f);
       
        Application.LoadLevel(scennumb);

    }

 /* void openstage()
    {
        Application.LoadLevel(1);
    }*/

    public void OpenmyURL (string url)
    {
        Application.OpenURL(url);
    }

    public void quitgame()
    {
        Application.Quit();
    }

    public void VolumeControl (float v)
    {
           //  volume. 
    }

 
}
