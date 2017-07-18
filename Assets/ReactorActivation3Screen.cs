using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReactorActivation3Screen : MenuScreen {

    [HideInInspector] public Button button1;
    [HideInInspector] public Button button2;
    [HideInInspector] public Button button3;

    public int durationInSeconds = 240;

    [HideInInspector] public MenuScreen NextScreen;

    private void Start() {
        NextButton();
    }

    int id = 0;
    private void NextButton() {
        id++;

        button1.interactable = ( id == 1 );
        button2.interactable = ( id == 2 );
        button3.interactable = ( id == 3 );

        if ( id == 4 )
            TransitionToMenuScreen( NextScreen );
    }


    public void StartButton( Button buttonPressed ) {
        StartCoroutine( ButtonAnimation( buttonPressed ) );
    }

    IEnumerator ButtonAnimation(Button button) {
        button.interactable = false;
        int duration = durationInSeconds;

        while (duration > 0) {
            int minutes = duration / 60;
            int seconds = duration % 60;

            button.GetComponentInChildren<Text>().text = minutes + ":" + seconds;

            yield return new WaitForSeconds( 1f );
            duration--;
        }

        button.GetComponentInChildren<Text>().text = "ACTIVATED";

        NextButton();
    }

    

    
}
