using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enmy2ex : MonoBehaviour {

    
    public Transform player;
    private Animator anim;
    public enmyhealth eh;

    public GameObject weapon0;
    public GameObject weapon1;


    public enmyatackex ea;


    // Use this for initialization
    private void Awake()
    {
        
    }

    void Start()
    {
       ea= GetComponent<enmyatackex> ();
        anim = GetComponentInChildren<Animator>();
      

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
              
                if (direction.magnitude > 8)
                {
                    weapon0.SetActive(true);
                    weapon1.SetActive(false);
                    this.transform.Translate(0, 0, 0.170f);
                    anim.SetBool("isWalk", true);
                    anim.SetBool("isAttack", false);

                   
                }
                else
                {
                    weapon0.SetActive(false);
                    weapon1.SetActive(true);
                    anim.SetBool("isIdle", true);
                    anim.SetBool("isWalk", false);
                    ea.inrage = true;
                }


            }
            else
            {
                weapon0.SetActive(true);
                weapon1.SetActive(false);
                ea.inrage = false;
                anim.SetBool("isIdle", true);
                anim.SetBool("isWalk", false);
                anim.SetBool("isAttack", false);
            }

        }
        else
        {   
            
            ea.inrage = false;

            anim.SetBool("isIdle", false);
            anim.SetBool("isWalk", false);
            anim.SetBool("isAttack", false);
            anim.SetBool("isDeath", true);

        }
    


}

}
