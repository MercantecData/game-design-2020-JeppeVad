using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow2 : MonoBehaviour
{
    public Transform player;
    private Vector3 velocity;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        var playerPos = player.position;
        playerPos.z = transform.position.z;
        
        var target = Vector3.SmoothDamp(transform.position, playerPos, ref velocity, 0.1f);
        transform.position = target;

    }
}
