using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardSounds : MonoBehaviour {
    public AudioClip[] Clips;

	// Update is called once per frame
	void Update () {
		if (Input.anyKeyDown && !Input.GetMouseButtonDown(0)) {
            int random = Random.Range( (int)0, (int)Clips.Length );

            AudioSource.PlayClipAtPoint( Clips[random], Camera.main.transform.position );
        }
	}
}
