using UnityEngine;
using System.Collections;

public class enemyctl : MonoBehaviour {

	public Transform playertransform;
	UnityEngine.AI.NavMeshAgent nma;

	void Awake () {
	
		playertransform = GameObject.FindGameObjectWithTag ("Player").transform;
		nma = GetComponent<UnityEngine.AI.NavMeshAgent> ();
	}
	void Update(){
		nma.SetDestination (playertransform.position);
		}

}
