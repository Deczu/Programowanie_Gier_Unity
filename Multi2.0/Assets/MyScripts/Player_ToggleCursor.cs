using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.Networking;

public class Player_ToggleCursor : NetworkBehaviour {
    public FirstPersonController fpsController;

    // Update is called once per frame
    void Update() {
        if (!isLocalPlayer)
        {
            return;
        }

        if (Input.GetButtonUp("Cancel"))
        {
            ToggleCursor();
        }
	
	}
    void ToggleCursor()
    {
        fpsController.enabled = !fpsController.enabled;

    }
}
