using UnityEngine;
using System.Collections;

public class opendoor : MonoBehaviour {

    public bool arrive =false;  
	 

	//private Animator ani ;

	void Start () {
		//door = GetComponent<Animator> ();
	}

	void OnTriggerEnter(Collider other ){
        if (other.tag == "Player")
            //ani.SetBool ("open", true);
            //door.SetActive(false);
            arrive = true;

		}


	// Update is called once per frame
	void Update () {
	
	}
}
