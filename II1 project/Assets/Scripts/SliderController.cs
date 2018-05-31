using UnityEngine.UI;
using UnityEngine;

public class SliderController : MonoBehaviour {

    public AudioSource music;
    public Slider slider;
	
	// Update is called once per frame
	void Update () {
        music.volume = slider.value;
	}
}
