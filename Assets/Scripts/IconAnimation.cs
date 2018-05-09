using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class IconAnimation : MonoBehaviour {
    [SerializeField]
    Sprite[] imagesArray;
    [SerializeField]
    float delay = 1 / 30.0f;
    [SerializeField]
    int state = 0;
    [SerializeField]
    float timer = 0;
    [SerializeField]
    Image image;

    // Use this for initialization
    void Start () {
        image = gameObject.GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        state = (int)(timer / delay);
        
        //out of range fix
        if (state >= imagesArray.Length)
        {
            state = 0;
            timer -= delay * imagesArray.Length;
        }

        image.sprite = imagesArray[state];
	}
}
