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
        go = GameObject.Find("World Origin");
    }

    void Update()
    {
        // InputDirection can be used as per the need of your project
        direction = jsMovement.InputDirection;
        var t = cam.transform;
        
        // If we drag the Joystick
        if (direction.magnitude != 0)
        {
            var nvec = t.forward * direction.y * moveSpeed +
                       t.right * direction.x * moveSpeed;
            nvec.y = 0;
            go.transform.position -= nvec;
        }
    }
}