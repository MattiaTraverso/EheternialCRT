using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour {
    public MenuScreen FirstScreen;

	void Start () {
        MenuScreen[] MenuScreens = GetComponentsInChildren<MenuScreen>();

        foreach (MenuScreen menu in MenuScreens) {
            menu.HideScreen();
        }

        FirstScreen.ShowScreen();
	}
}
