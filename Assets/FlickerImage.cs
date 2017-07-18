using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class FlickerImage : MonoBehaviour {
    public float time = .2f;
    public int amount = 5;

    public Sprite sprite1;
    public Sprite sprite2;

    private Image image;

    private void Start() {
        image = GetComponent<Image>();
    }


    void OnEnable() {
        StopAllCoroutines();

        StartCoroutine( FlickerCoroutine() );
    }

    IEnumerator FlickerCoroutine() {
        int amountFlickering = amount;

        while (amountFlickering > 0) {
            amountFlickering--;

            FlipImages();

            yield return new WaitForSeconds( time );
        }
    }

    private void FlipImages() {
        if ( image == null ) image = GetComponent<Image>();

        if ( image.sprite == sprite1 ) image.sprite = sprite2; else image.sprite = sprite1;
    }
}
