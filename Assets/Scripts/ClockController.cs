using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockController : MonoBehaviour
{
    [SerializeField]
    float clockCounter = 0;

    [SerializeField]
    RectTransform clockRectangle;
    [SerializeField]
    float clockRectangleMin = -40;

    [SerializeField]
    Image clockBlue;
    [SerializeField]
    float fillAmountMin = 0.01f;

    [SerializeField]
    Text clockText;

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        //clockRectangle
        clockBlue.fillAmount = clockCounter * 2 / 5 + fillAmountMin;
        clockRectangle.rotation = Quaternion.Euler(0, 0, -clockCounter * 143.85f + clockRectangleMin);
        clockText.text = ((int)(clockCounter * 100)).ToString();

    }
}
