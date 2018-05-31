using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musleflash : MonoBehaviour {

    public float lifetime;
	// Use this for initialization
	void Start () {
		
	}
	
    void OnEnable()
    {
        Invoke("setact", lifetime);
    }
    void setact()
    {
        gameObject.SetActive(false);
    }
	// Update is called once per frame
	void Update () {
        transform.localEulerAngles = new Vector3(0, Random.Range(0, 359), 0);
	}
}
