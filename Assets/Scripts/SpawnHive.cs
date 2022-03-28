using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHive : MonoBehaviour
{
    public Camera Cam;
    public GameObject Model;
    
    // Start is called before the first frame update
    void Start()
    {
        var cameraPos = Cam.transform.position;
        cameraPos.y -= 1.8f;
        Model.transform.position = cameraPos;
    }
}
