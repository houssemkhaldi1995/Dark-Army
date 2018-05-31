#pragma strict


function Start () {
   GetComponent.<Animation>()["Attack"].layer = 1;
   GetComponent.<Animation>()["Attack"].wrapMode = WrapMode.Once;
}

function Update () {
  if(Input.GetKeyDown("l")){
  GetComponent.<Animation>().Play("Attack");
}
}