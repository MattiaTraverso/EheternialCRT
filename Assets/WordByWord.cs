using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordByWord : MonoBehaviour {
    public float duration = 2f;

    private float timer = 0f;
    private string backupText;

    private void Start() {
        backupText = GetComponentInChildren<Text>().text;
        GetComponentInChildren<Text>().text = "";
    }

    private void OnEnable() {
        timer = 0f;
    }

    void Update () {
        if ( timer >= duration )
            return;

        timer += Time.deltaTime;

        if (backupText.Length > 0)
            GetComponentInChildren<Text>().text = backupText.Substring( 0, (int)( timer / duration * (backupText.Length)) );
    }
}
