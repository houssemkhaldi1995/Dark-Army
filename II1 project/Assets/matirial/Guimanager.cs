using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guimanager : MonoBehaviour {


    public RenderTexture minitexture;
    public Material minimat;

    void OnGUI()
    {
        if (Event.current.type == EventType.Repaint)
            Graphics.DrawTexture(new Rect(0, 0, 256, 256), minitexture , minimat);

    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
