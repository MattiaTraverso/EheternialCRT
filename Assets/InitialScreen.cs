using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InitialScreen : MenuScreen {
    [HideInInspector]
    public Button MainButton;

    [System.Serializable]
    public class PasswordThing {
        public string pass;
        public InputField InputField;
    }

    public PasswordThing[] Passwords;

    private void Start() {
        MainButton.interactable = true;

        foreach ( PasswordThing pt in Passwords ) {
            pt.InputField.interactable = true;
        }

        AccessDenied.gameObject.SetActive( false );
        AccessGranted.gameObject.SetActive( false );
    }

    public override void MainButtonFunction() {
        bool codeWasRight = true;

        foreach ( PasswordThing pt in Passwords ) {
            if ( pt.InputField.text != pt.pass )
                codeWasRight = false;
        }

        StartCoroutine( AccessState( codeWasRight ) );
    }

    [HideInInspector] public FlickerImage AccessGranted;
    [HideInInspector] public FlickerImage AccessDenied;

    [HideInInspector] public MenuScreen NextScreen;

    IEnumerator AccessState( bool granted = false ) {
        MainButton.interactable = false;

        foreach ( PasswordThing pt in Passwords ) {
            pt.InputField.interactable = false;
        }

        AccessGranted.gameObject.SetActive( granted );
        AccessDenied.gameObject.SetActive( !granted );

        FlickerImage f = ( granted ) ? AccessGranted : AccessDenied;

        yield return new WaitForSeconds( f.time * f.amount );

        if ( !granted ) {
            AccessDenied.gameObject.SetActive( false );

            MainButton.interactable = true;

            foreach ( PasswordThing pt in Passwords ) {
                pt.InputField.interactable = true;
            }

        } else {
            TransitionToMenuScreen( NextScreen );
        }

        yield return null;
    }




}
