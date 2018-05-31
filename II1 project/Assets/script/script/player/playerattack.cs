using UnityEngine;
using System.Collections;

public class playerattack : MonoBehaviour {

    
   


    private Animator anim;
    //public  AudioClip sound;

	void Start () {

        anim = GetComponentInChildren<Animator>();
    }

   
	// Update is called once per frame
	void Update () {
	if(Input.GetButton("Fire1")) {
            

            anim.SetBool ("isshoot", true);
           
           Invoke("finattack",1f);
           
          
                

        }
       

    }

    void finattack()
    {
        anim.SetBool("isshoot", false);


    }



}
