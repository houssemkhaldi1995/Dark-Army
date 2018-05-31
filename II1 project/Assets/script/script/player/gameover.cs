using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameover : MonoBehaviour {

	public bool isActive = false;
	public GameObject gamover;


	// Update is called once per frame
	void Update () {
		// menu is affiche
		if (isActive) {


			//Cursor.visible = true;
			// Cursor.lockState = CursorLockMode.Confined;
			gamover.SetActive(true);

			Debug.Log ("Game Over");
			Time.timeScale = 0;
		} else {// menu non affichier

			// Cursor.visible = false;
			// Cursor.lockState = CursorLockMode.Locked;
			Time.timeScale = 1;
		}

	}


	public	void deathh(bool v){
		isActive = v;
	}

}