using UnityEngine;
using System.Collections;

public class enmy2 : MonoBehaviour {
	public Transform player;
	private Animator anim;
	public enmyhealth eh;

  //  public AudioClip[] audioClip;
  public  AudioSource audioatack;
    public AudioSource audiodeath;
    public AudioSource audiowalk;


	public float timetoatk = 0.5f;
	private float timer  ;
    // Use this for initialization
	int n =0,m = 0;




    void Start () {
		//anim = GetComponent<Animator> ();hg
      anim =  GetComponentInChildren<Animator>();
        eh =GetComponent<enmyhealth> ();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (eh.isdeath == false)
        {

            if (Vector3.Distance(player.position, this.transform.position) < 20)
            {
                Vector3 direction = player.position - this.transform.position;
                direction.y = 0;
                this.transform.rotation = Quaternion.Slerp(this.transform.rotation,
                  Quaternion.LookRotation(direction), 0.1f);
                anim.SetBool("isIdle", false);
             
				if (direction.magnitude > 1.2) {  
					if( audiowalk.isPlaying ==false && m ==0)
					{
					  audiowalk.Play();
					m = 1;
				}
                    this.transform.Translate(0, 0, 0.2f);
                    anim.SetBool("isWalk", true);
                    anim.SetBool("isAttack", false);
                }
                else
					
				{   
					timer += Time.deltaTime;



					if (audioatack.isPlaying == false && timer >=5* timetoatk) {
						audioatack.Play ();
						timer = 0;
					}
                    anim.SetBool("isAttack", true);
                    anim.SetBool("isWalk", false);


                }
            }
            else
            {
               // audiowalk.Pause();
                anim.SetBool("isIdle", true);
                anim.SetBool("isWalk", false);
                anim.SetBool("isAttack", false);
            }

        }
        else
		{   if (audiodeath.isPlaying == false && n == 0) {
				audiodeath.Play ();
				n = 1;
			}
            anim.SetBool("isIdle", false);
            anim.SetBool("isWalk", false);
            anim.SetBool("isAttack", false);
            anim.SetBool("isDeath", true);
		

			}
    }




}
