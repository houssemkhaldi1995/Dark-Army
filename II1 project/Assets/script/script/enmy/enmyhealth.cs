using UnityEngine;
using System.Collections;

public class enmyhealth : MonoBehaviour {
	 
	public int  fulhealth =100;

	public int curhealth;
	public int scorevalue =10;

	public bool isdeath=false;
   public static int nbmort ;

	public AudioSource audiodeath;
//	public GameObject impactEffect ;
	//public enmy2 e2 ;


	void Awake(){
		curhealth = fulhealth;
		 //e2.GetComponent<enmy2> ();

		}

	public void gethurt(int  damgeamount){
		if (isdeath)
						return;
		curhealth -= damgeamount;
		//GameObject	impactGO = Instantiate(impactEffect, gameObject.transform, Quaternion.LookRotation(gameObject.transform));
		if (curhealth <= 0)
						killenmy ();

		}
	void killenmy(){
		isdeath = true;
        nbmort++;
		audiodeath.Play ();
		//vanishing
		Destroy (gameObject, 4f);
		}

}
