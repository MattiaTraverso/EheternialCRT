using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReactorActivation2Screen : MenuScreen {
    public float appearTime = 5f;
    private float appearTimer = 0f;

    [HideInInspector] public Button activationButton = null;

    public override void ShowScreen() {
        base.ShowScreen();

        appearTimer = 0f;
        activationButton.gameObject.SetActive( false );
    }

    private void Update() {
        if ( activationButton.gameObject.activeSelf )
            return;

        appearTimer += Time.deltaTime;

        if (appearTimer >= appearTime ) {
            activationButton.gameObject.SetActive( true );
        }
    }
}

