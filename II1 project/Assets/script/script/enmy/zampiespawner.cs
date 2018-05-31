using UnityEngine;
using System.Collections;

public class zampiespawner : MonoBehaviour {

	public GameObject zambie;
    private bool first = true;

	void OnTriggerEnter(Collider other){

        if (other.gameObject.tag == "Player" && first == true)
        {
            Instantiate(zambie, transform.position, transform.rotation);
            first = false;

        }
		}



}
