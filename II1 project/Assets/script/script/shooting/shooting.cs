using UnityEngine;
using System.Collections;

public class shooting : MonoBehaviour {
	
	public int shotdamage=20;
	public float reloadtime =.2f;
	public float range =50f;
	
	
	private float timer ;
	private Ray rayshot ;
	private RaycastHit hit ;
	
	
	private LineRenderer shotline;
	private AudioSource shotaudio;
	private Light shotlight;
  //	private float shoteffect = 0.2f;
	
	//pour attrapper silè7
	//public GameObject weapon;


        //animer attack
         Animator anim;



    void Awake(){
		
		shotline = GetComponent<LineRenderer> ();
		shotaudio = GetComponent<AudioSource> ();
		shotlight = GetComponent<Light> ();
        //anim = GetComponent<Animator>();

    }
	
	void Update () {
		timer += Time.deltaTime;
		if (Input.GetButton ("Fire1") && timer >= reloadtime) {
            //	if(weapon.activeInHierarchy)
            
				shoot();		
			
		}
	}

    void attend()
    {
        Debug.Log("attend");
    }
	
	void shoot(){
		timer = 0f;
		shotaudio.Play ();
		shotlight.enabled = true;
		shotline.enabled = true;
		shotline.SetPosition (0, transform.position);
		rayshot.direction = transform.forward;
       // Invoke("attend", 1);
        if (Physics.Raycast(transform.position, transform.forward , out hit ))
		{ 
			
			enmyhealth eh = hit.collider.GetComponent<enmyhealth>();
			
			if(eh != null)
			{
               
               
				eh.gethurt(shotdamage);

                anim =  hit.collider.GetComponent<Animator>();
                anim.SetBool("isFrapp", true);
                Invoke("finanim", 2);

                shotline.SetPosition(1,hit.point);
			}
		}
		else{
			
			shotline.SetPosition(1,transform.position + range * transform.forward);
			
			
			
		}
      //  Invoke("destory", 1f);
	}
	
	void disableeffect(){
		shotlight.enabled = false;
		shotline.enabled = false;
		
		
	}
	
	void destory()
    {
       // shotline.SetPosition(1, transform.position);
    }
    void finanim()
    {
        Debug.Log("findamage");
        anim.SetBool("isFrapp", false);
       // anim.SetBool("isIdle", true);


    }



}
