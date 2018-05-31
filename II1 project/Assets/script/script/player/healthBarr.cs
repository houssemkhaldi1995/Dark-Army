using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class healthBarr : MonoBehaviour {

    public Image currenthealthBar;
    public Text ratioText;

    public plearhealth ph;
  //  private float hitpoint ;
    private float maxhitpoint ;


    private void Awake()
    {
        ph = GetComponent<plearhealth>();
       // hitpoint = ph.curthealth;
        maxhitpoint = ph.fulhealth;
    }

    private void Start()
    {
        UpdateHealthBar();
      
    }

  public void UpdateHealthBar()
    {
		float ratio =ph.curthealth / maxhitpoint;
        currenthealthBar.rectTransform.localScale = new Vector3(ratio, 1, 1);
        ratioText.text = (ratio*100).ToString("0") + '%';  
        
            }

   /* private void TakeDamage(float damage)
    {
		ph.curthealth -= damage;
        Debug.Log("takedamage");
       // ph.curthealth = hitpoint ;
		if (ph.curthealth < 0 )
		{     Time.timeScale = 0;
			ph.curthealth = 0;
            ph.killplayer();
            Debug.Log("Dead");
        }
        UpdateHealthBar();
    }
*/
    private void HealthDamage (float heal)
    {
		ph.curthealth += heal;
		ph.curthealth =ph.curthealth;
		if (ph.curthealth > maxhitpoint)
        {
			ph.curthealth = maxhitpoint;
        }
        UpdateHealthBar();
        }
}
