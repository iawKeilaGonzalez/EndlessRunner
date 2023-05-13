using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] Vector3 cameraVelocity;
    [SerializeField] float smothTime = 1;
    [SerializeField] bool lookAtPlayer;
    [SerializeField] int lowerLimit;
    void Update()
    {
        //transform.position = new Vector3(transform.position.x, player.position.y,transform.position.z);
        if (player.position.y > lowerLimit)
        {
            Vector3 targetPosition = new Vector3(transform.position.x, player.position.y,transform.position.z);
            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref cameraVelocity, smothTime);
            if (lookAtPlayer == true)
            {
                transform.LookAt(player);
            }
        }
    }
}

