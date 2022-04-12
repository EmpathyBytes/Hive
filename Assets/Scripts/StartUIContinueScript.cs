using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartUIContinueScript : MonoBehaviour
{
    public void Run()
    {
        var scm = SceneManagement.GetInstance();
        if (scm is null) return;
        scm.LoadMainScene();
    }
}
