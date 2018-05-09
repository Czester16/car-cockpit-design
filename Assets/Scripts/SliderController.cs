using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class SliderController : MonoBehaviour
{
    [SerializeField]
    float timer = 0;
    [SerializeField]
    float sequenceTime = 30;
    [SerializeField]
    Slider slider;
    [SerializeField]
    float tweakSlider = 0.1f;

    // Use this for initialization
    void Start ()
    {
        slider = gameObject.GetComponent<Slider>();
    }
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (timer > sequenceTime)
        {
            timer = timer % sequenceTime;
        }

        if (timer < sequenceTime / 2)
        {
            slider.value = (1 + tweakSlider) - (timer / sequenceTime * 2);
        }
        else
        {
            slider.value = timer / sequenceTime * 2 - (1 - tweakSlider);
        }

    }
}
