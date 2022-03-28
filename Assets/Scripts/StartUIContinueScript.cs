using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartUIContinueScript : MonoBehaviour
{
    public void Run()
    {
        var scmgo = GameObject.Find("SceneManagement");
        if (scmgo is null) return;
        var scm = scmgo.GetComponent<SceneManagement>();
        if (scm is null) return;
        scm.LoadMainScene();
    }
}
