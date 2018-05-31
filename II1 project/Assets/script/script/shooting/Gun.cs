using UnityEngine;

public class Gun : MonoBehaviour {


    public int damage;
    public float fireRate;
    public float nextFire;
    public ParticleSystem muzzleFlash;
    public GameObject impactEffect;
    public AudioSource shootSound;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton("Fire1") /*&& Time.time > nextFire*/)
        {
          //  nextFire = Time.time + fireRate;
            shootSound.Play();
            muzzleFlash.Play();
            Shoot();
        }
	}
    void Shoot()
    {
        RaycastHit hitInfo;
        if (Physics.Raycast(transform.position,transform.forward,out hitInfo,50f))
        {
            enmyhealth target = hitInfo.transform.GetComponent<enmyhealth>();
            if (target != null)
            {
                target.gethurt(damage);
                GameObject impactGO = Instantiate(impactEffect, hitInfo.point, Quaternion.LookRotation(hitInfo.normal));
                Destroy(impactGO, 1f);
            }
           
        }
    }
}
