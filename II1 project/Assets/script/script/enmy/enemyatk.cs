using UnityEngine;
using System.Collections;

public class enemyatk : MonoBehaviour {

	public GameObject player;
	private plearhealth ph;

	public enmyhealth eh;

	public float timetoatk = 0.5f;
		public int atkamount =3;
			private bool inrage =false;
			private float timer ;
	//
	// Update is called once per frame
	void Awake () {
	  if (player == null)
						player = GameObject.FindGameObjectWithTag ("Player");

		ph = player.GetComponent<plearhealth> ();

		eh.GetComponent<enmyhealth> ();
    
    }


	void Update(){

		timer += Time.deltaTime;
        
       
		if ( timer >= timetoatk && inrage  && eh.curhealth > 0) {
           
            attak ();

				}

		}

	void attak(){
        if (ph.curthealth > 0)
        {
            ph.gethurt(atkamount);

           // player.SendMessage("TakeDamage", atkamount);
            timer = 0f;

        }
		}


	void OnTriggerEnter(Collider other){
		if (other.gameObject == player)
						inrage = true;
          

        
		}

	void OnTriggerExit(Collider other){
		if (other.gameObject == player)
			inrage = false;
		}
}
