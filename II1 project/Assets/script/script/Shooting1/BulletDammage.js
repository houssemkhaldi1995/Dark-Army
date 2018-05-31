#pragma strict

var Dammage = 100;

function OnCollisionEnter (info : Collision)
{   Debug.Log("oui");
	info.transform.SendMessage("gethurt", Dammage, SendMessageOptions.DontRequireReceiver);


}