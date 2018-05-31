using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
//using UnityEngine.UI;

public class plearhealth : MonoBehaviour {
    
	public float fulhealth= 1000f;
	public float curthealth ;
	public bool isdeath =false ;
	
	//public AudioSource audioover;
	public AudioSource audiodebut;
	public AudioSource audiomort;
    healthBarr hb;
    time timer;
	private Animator anim;

    
	//public GameObject gamover;

    
 




	void Awake(){
        
        curthealth = fulhealth;
		anim = GetComponentInChildren<Animator> ();
       hb =GetComponent<healthBarr>();
        timer = GetComponentInChildren<time>();


    }



	/*void OnGUI(){
		GUI.Box (new Rect (20, 20, 200, 40), curthealth.ToString () + "/" + fulhealth.ToString ());



		}*/

 void savescene()
    {
        PlayerPrefs.SetInt("hinbr", SceneManager.GetActiveScene().buildIndex);
    }



    public void gethurt(int hurtamong)
    {
        if (!isdeath)
        {
            curthealth -= hurtamong;

            if (curthealth <= 0 || timer.timer ==0)
            {
                curthealth = 0;
                killplayer();
            }
            hb.UpdateHealthBar();
        }
    }
	public void killplayer(){
        isdeath = true;
		audiomort.Play ();
		anim.SetTrigger ("death");

		Invoke ("sound", 2f);
   
        audiodebut.Stop ();
        
        savescene();
		Debug.Log ("Game Over");
	
	
     
        }

	void sound(){
       
       
        SceneManager.LoadScene (8);
        enmyhealth.nbmort = 0;
    }
}
