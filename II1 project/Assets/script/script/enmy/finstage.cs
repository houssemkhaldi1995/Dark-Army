using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class finstage : MonoBehaviour {

    enmyhealth eh;
    
    //public int nstage;
    public GameObject effect;
    public GameObject enmy;
    public GameObject door;
    public Transform objfin;
	public AudioSource audiofin;
	public AudioSource audiodebut;
    Animator anim;
   // UnityEngine.AI.NavMeshAgent pma;
    opendoor od;


    void Awake()
    {
        anim = GetComponentInChildren<Animator>();
        eh = enmy.GetComponent<enmyhealth>();
       // pma =GetComponent<UnityEngine.AI.NavMeshAgent>();
        od = door.GetComponent<opendoor>();
    }
    void Update()
    {
        if (eh.isdeath)
		{   if(audiofin.isPlaying ==false)
			audiofin.Play();
            audiodebut.Stop();
            effect.SetActive(true);
          // anim.SetBool("isDeath", true);
            Debug.Log("you win");
            
            anim.SetTrigger("walkfin");
			

            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.Confined;

            Invoke("fin", 2f);
            
        }



    }
    
    void open()
    {
        //Application.LoadLevel(nstage);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void fin()
    {
        Vector3 direction = objfin.position - this.transform.position;
        direction.y = 5;
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation,
          Quaternion.LookRotation(direction), 0.1f);
        this.transform.Translate(0, 0, 0.1f);


        if (od.arrive)
        {
            //ani.SetBool ("opendoor", true);
            door.SetActive(false);
            Invoke("open", 1.85f);
        }
    }


}
