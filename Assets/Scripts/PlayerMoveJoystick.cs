using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

// This code was referenced from an online tutorial
// https://clay-atlas.com/us/blog/2021/10/25/unity-virtual-joystick/

public class PlayerMoveJoystick : MonoBehaviour
{
    // Init
    public const float moveSpeed = 0.05f;
    public MoveJoystick jsMovement;
    public Vector3 direction;
    private Camera cam;
    private GameObject go;

    private void Start()
    {
        cam = Camera.main;
        go = GameObject.Find("Hive");
    }

    void Update()
    {
        // InputDirection can be used as per the need of your project
        direction = jsMovement.InputDirection;

        // If we drag the Joystick
        if (direction.magnitude != 0)
        {
            // TODO make it so that it doesn't account for vertical movement because haha *phases through the floor*
            go.transform.position -= cam.transform.forward * direction.y * moveSpeed +
                                      cam.transform.right * direction.x * moveSpeed;
        }
    }
}