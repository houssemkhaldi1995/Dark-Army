using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enmyatackex : MonoBehaviour {

    public GameObject player;
    private plearhealth ph;

    public enmyhealth eh;

    public float timetoatk = 6f;
    public int atkamount = 40;
    public bool inrage = false;
    private float timer;

   // public GameObject weapon0;
    public GameObject weapon1;

    private AudioSource shotaudio;
    // Update is called once per frame
    void Awake()
    {
        if (player == null)
            player = GameObject.FindGameObjectWithTag("Player");

        ph = player.GetComponent<plearhealth>();

        eh.GetComponent<enmyhealth>();
        shotaudio = GetComponent<AudioSource>();

    }


    void Update()
    {
      
        timer += Time.deltaTime;
       
        if (timer >= timetoatk && inrage && eh.curhealth > 0)
        {
          
            attak();
           
        }

    }

    void attak()
    {
       // weapon0.SetActive(false);
        weapon1.SetActive(true);
       // Invoke("finshoot", 2f);
        shotaudio.Play();
        if (ph.curthealth > 0)
            
            ph.gethurt(atkamount);

        player.SendMessage("TakeDamage", 30);
        timer = 0f;


    }

    void finshoot()
    {
      //  weapon0.SetActive(true);
        weapon1.SetActive(true);

    }


  
}
