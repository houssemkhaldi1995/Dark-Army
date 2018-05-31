using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerazoom : MonoBehaviour {
    public GameObject muzlleflash;
    public GameObject crosshair;
    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
          transform.localPosition = new Vector3(-1, 2.11f, -0.8f);
            muzlleflash.transform.localPosition = new Vector3(-0.3f, -0.2f, 0.55f);
            crosshair.SetActive(true);
        }
        if (Input.GetMouseButtonUp(1))
        {
          transform.localPosition = new Vector3(0, 3.5f, -4f);
            muzlleflash.transform.localPosition = new Vector3(0,0,0);
            crosshair.SetActive(false);
       }

    }
}
