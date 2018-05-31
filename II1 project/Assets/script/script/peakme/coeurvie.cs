using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class coeurvie : MonoBehaviour {

    public GameObject player;
    public GameObject effet;
    
    public AudioClip ac;
    private float timer =0f;

    bool pressed = false;

    void Awake()
    {
        if (player == null)
            player = GameObject.FindGameObjectWithTag("Player");
    }

    void OffLogo()
    {
        //do anything(delete or invisible)
        //Debug.Log("oui");
        effet.SetActive(false);
        pressed = false;
        Destroy(gameObject);


    }



    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
           // Debug.Log("ok");
            AudioSource.PlayClipAtPoint(ac, transform.position);
            player.SendMessage("HealthDamage", 40);
           
            effet.SetActive(true);
            this.enabled = true;
            this.transform.localScale = new Vector3(0, 0, 0);

            if (!pressed)
            {
                pressed = true;
                
                Invoke("OffLogo", 2);
                
            }
          



        }
    }
  
}
