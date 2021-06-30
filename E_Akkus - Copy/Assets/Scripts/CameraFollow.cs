using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Vector3 playerPos = player.position;
        Vector3 cameraPos = transform.position;
        cameraPos.x = playerPos.x;
        //cameraPos.y = playerPos.y;            (Use it if you want vertical jump game)

        transform.position = cameraPos;

    }
}
