using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class viseur : MonoBehaviour {



    private void OnGUI()
    {
        GUI.Label(new Rect(Screen.width / 2,Screen.height /2 -30,200,200) , "x");
    }
}
