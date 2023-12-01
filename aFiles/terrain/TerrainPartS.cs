using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainPartS : MonoBehaviour
{
    TerrainMoverS _terrainMover;
    private void Awake()
    {
        _terrainMover = FindAnyObjectByType<TerrainMoverS>();
    }
    private void FixedUpdate()
    {
        if (_terrainMover != null && Time.deltaTime > 0f)
        {
            transform.position = new Vector3 (transform.position.x,
                transform.position.y,
                transform.position.z + _terrainMover.offsetVelocity);
        }
    }
}
