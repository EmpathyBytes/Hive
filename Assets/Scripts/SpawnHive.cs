using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class SpawnHive : MonoBehaviour
{
    public Camera Cam;
    public GameObject GameObject;
    
    // Start is called before the first frame update
    void Start()
    {
        var cameraPos = Cam.transform.position;
        cameraPos.y -= 1.8f;
        GameObject.transform.position = cameraPos;
    }
}
