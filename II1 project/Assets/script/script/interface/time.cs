using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class time : MonoBehaviour {

public float  timer = 500f;

    public Text ratioText;
    


 

    private void Start()
    {
        Updatetime();

    }

    private void Updatetime()
    {
  
        ratioText.text = "TIME " + "\r\n" + ' ' + (timer).ToString("0") ;

    }
    void Update () {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            timer = 0;
        }
        Updatetime();

    }

 
}
