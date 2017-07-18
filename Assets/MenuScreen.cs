using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuScreen : MonoBehaviour {
    public virtual void ShowScreen() {
        gameObject.SetActive( true );
    }

    public virtual void HideScreen() {
        gameObject.SetActive( false );
    }

    public virtual void MainButtonFunction() {

    }
    

    public virtual void TransitionToMenuScreen(MenuScreen screen) {
        HideScreen();
        screen.ShowScreen();
    }

    public virtual void BackButton(MenuScreen screen) {
        TransitionToMenuScreen( screen );
    }
	

}
