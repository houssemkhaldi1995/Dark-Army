using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turnig : MonoBehaviour {

	Rigidbody rb;
	float camraylenght =100f;
    public float speed = 0.0001f;

    // Use this for initialization

    void Awake(){
		rb = GetComponent<Rigidbody> ();
    }


	void turning() {
		Ray camray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit hit;
		if (Physics.Raycast (camray, out hit, camraylenght)) {
            Vector3 playerToMouse = hit.point - transform.position;
            playerToMouse.y = 0f;
            Quaternion newRotation = Quaternion.LookRotation(playerToMouse);
            transform.rotation = Quaternion.Lerp(transform.rotation, newRotation,Time.deltaTime);
            rb.MoveRotation(newRotation);
        }
	}
	// Update is called once per frame
	void FixedUpdate () {		
			turning();
	}
}
