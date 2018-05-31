#pragma strict

var Effect : Transform;
var TheDammage = 100;
var shootaudio : AudioSource;
//var   impactEffect :GameObject;

//jkj

function Update () {
	
	var hit : RaycastHit;
	var ray : Ray = Camera.main.ScreenPointToRay(Vector3(Screen.width*0.5, Screen.height*0.5, 0));
	
	if (Input.GetMouseButtonDown(0))
	{    shootaudio.Play();
	        if (Physics.Raycast (ray, hit, 100))
		
		{
			var particleClone = Instantiate(Effect, hit.point, Quaternion.LookRotation(hit.normal));
			//var eh = hit.collider.GetComponent<enmyhealth>();
			
			//if(eh != null)
			//var impactGO = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
			
			Destroy(particleClone.gameObject, 0.5);
			hit.transform.SendMessage("gethurt", TheDammage, SendMessageOptions.DontRequireReceiver);
		}
	}
	
}