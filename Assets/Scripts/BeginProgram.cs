using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;

public class BeginProgram : MonoBehaviour
{

    public Canvas Ui;
    public GameObject GObject;
    public Camera ARCam;
    public Material CustomMaterial;
    public ARSessionOrigin ARSOrigin;
    public GameObject TrackingPointPrefab;


    // Start is called before the first frame update
    public void Run()
    {
        RemoveUI();
        EnableGObject();
        DisablePassthrough();
        DisableTrackingPoints();
    }

    private void RemoveUI()
    {
        var scaler = Ui.GetComponent<CanvasScaler>();
        var grc = Ui.GetComponent<GraphicRaycaster>();
        if (scaler is not null) Destroy(scaler);
        if (grc is not null) Destroy(grc);
        Destroy(Ui);
    }

    private void EnableGObject()
    {
        GObject.SetActive(true);
        var cameraPos = ARCam.transform.position;
        cameraPos.y -= 1.8f;
        GObject.transform.position = cameraPos;
    }

    private void DisablePassthrough()
    {
        var camBg = ARCam.GetComponent<ARCameraBackground>();
        if (camBg is not null) Destroy(camBg);
    }

    private void DisableTrackingPoints()
    {
        Destroy(TrackingPointPrefab);
        var pcm = ARSOrigin.GetComponent<ARPointCloudManager>();
        if (pcm is null) return;
        pcm.enabled = false;
        foreach (var point in pcm.trackables)
        {
            point.gameObject.SetActive(false);
        }
    }
}
