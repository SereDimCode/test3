using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainMoverS : MonoBehaviour
{
    //=========================================================== Editor
    public HandlerPlayerS handlerPlayer;
    //=========================================================== Editor
    public float offsetVelocity;
    private void Awake()
    {
        offsetVelocity = 0f;
    }
    private void FixedUpdate()
    {
        offsetVelocity = -(handlerPlayer.rb.velocity.z * Time.fixedDeltaTime);
    }
}
