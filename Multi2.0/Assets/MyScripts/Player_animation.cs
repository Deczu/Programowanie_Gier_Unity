using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;

public class Player_animation : NetworkBehaviour {

    public Animator playerAnimator;
	
	// Update is called once per frame
	void Update () {
        CheckForPlayerInput();
	}

    void CheckForPlayerInput()
    {
        if (!isLocalPlayer) return;
        if(Mathf.Abs(Input.GetAxis("Vertical"))>0 || Mathf.Abs(Input.GetAxis("Horizontal")) > 0 )
        {
            playerAnimator.SetBool("Moving", true);

        }
        else
        {
            playerAnimator.SetBool("Moving", false);
        }

    }
}
