using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enmy2spidre : MonoBehaviour {

    public Transform player;
    private Animator anim;
     enmyhealth eh;


    // Use this for initialization





    void Start()
    {
        //anim = GetComponent<Animator> ();
        anim = GetComponentInChildren<Animator>();
        eh = GetComponent<enmyhealth>();

    }

    // Update is called once per frame
    void Update()
    {
        if (eh.isdeath == false)
        {

            if (Vector3.Distance(player.position, this.transform.position) < 40)
            {
                Vector3 direction = player.position - this.transform.position;
                direction.y = 0;
                this.transform.rotation = Quaternion.Slerp(this.transform.rotation,
                  Quaternion.LookRotation(direction), 0.1f);
                anim.SetBool("isIdle", false);
                if (direction.magnitude > 2)
                {
                    this.transform.Translate(0, 0, 0.2f);
                    anim.SetBool("isWalk", true);
                    anim.SetBool("isAttack", false);
                }
                else
                {
                    anim.SetBool("isAttack", true);
                    anim.SetBool("isWalk", false);


                }
            }
            else
            {
                anim.SetBool("isIdle", true);
                anim.SetBool("isWalk", false);
                anim.SetBool("isAttack", false);
            }

        }
        else
        {
            anim.SetBool("isIdle", false);
            anim.SetBool("isWalk", false);
            anim.SetBool("isAttack", false);

            this.transform.Translate(new Vector3(0, 1, 0));
            transform.Rotate(3.08f, 188.3f, -160.7f);
            // anim.SetBool("isDeath", true);

        }
    }
}
