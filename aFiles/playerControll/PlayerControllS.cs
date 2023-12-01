using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllS : MonoBehaviour
{
    //=========================================================== Editor
    public HandlerPlayerS handlerPlayer;
    //=========================================================== Editor
    private void Update()
    {
        if (Input.touchCount > 0)
        {
            if (Input.GetTouch(0).position.y < Screen.height - ((float)Screen.height / 6f)) //up of the screen is untouchable
            {
                handlerPlayer.playerMovement.Jump();
            }
        }
    }
}
