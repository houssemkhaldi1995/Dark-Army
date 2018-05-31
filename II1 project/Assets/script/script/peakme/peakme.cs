using UnityEngine;
using System.Collections;

public class peakme : MonoBehaviour {
	 //shooting sh;
	public GameObject weapon0;
	public GameObject weapon1;

	// Use this for initialization
	void Start () {
		//sh = FindObjectOfType<shooting> ();
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider other) {
	if (other.gameObject.tag == "Player") {
			Debug.Log ("Game Over");
			Destroy(gameObject );
			weapon0.SetActive(false); 

            weapon1.SetActive(true);  //.weapon.SetActive(true);
		
				}
	}
}
