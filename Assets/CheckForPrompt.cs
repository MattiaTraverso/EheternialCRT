using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckForPrompt : MonoBehaviour {

    public InputField input;
    public string correctText;
    public string revealText;

	// Update is called once per frame
	void Update () {
		if (input.text == correctText) {
            GetComponentInChildren<Text>().text = revealText;
        }

        else {
            GetComponentInChildren<Text>().text = "";
        }
	}
}
