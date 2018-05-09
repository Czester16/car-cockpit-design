using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class IconBlinking : MonoBehaviour
{
    [SerializeField]
    float timer = 0;
    [SerializeField]
    float sequenceTime = 1;
    [SerializeField]
    Color baseColor = Color.white;
    [SerializeField]
    Image image;

    // Use this for initialization
    void Start ()
    {
        image = gameObject.GetComponent<Image>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        timer += Time.deltaTime;
        if(timer > sequenceTime)
        {
            timer = timer % sequenceTime;
        }

        if(timer < sequenceTime / 2)
        {
            image.color = baseColor * (timer / sequenceTime * 2);
        } else
        {
            image.color = baseColor * (sequenceTime - (timer / sequenceTime * 2 - sequenceTime));
        }
    }
}
