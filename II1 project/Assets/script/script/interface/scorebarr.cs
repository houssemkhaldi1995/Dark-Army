using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class scorebarr : MonoBehaviour {

    public Text scor;
    public Text nbkill;


    private void Update()
    {
        UpdateHealthBar();
    }

    private void Start()
    {
        UpdateHealthBar();

    }

    private void UpdateHealthBar()
    {

        scor.text = "SCORE " + "\r\n" + ' ' + (enmyhealth.nbmort * 10).ToString("0");
        nbkill.text = "X " + (enmyhealth.nbmort).ToString("0");

    }

}
