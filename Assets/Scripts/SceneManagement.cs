using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene("ARFoundation", LoadSceneMode.Additive);
        SceneManager.LoadScene("StartUI", LoadSceneMode.Additive);
        SceneManager.LoadScene("TrackingQuality", LoadSceneMode.Additive);
    }

    public void LoadMainScene()
    {
        SceneManager.UnloadSceneAsync("StartUI").Yield(); // Equivalent of await task completion
        SceneManager.UnloadSceneAsync("TrackingQuality").Yield();
        SceneManager.LoadScene("HiveL2", LoadSceneMode.Additive);
        SceneManager.LoadScene("TouchUI", LoadSceneMode.Additive);
        SceneManager.LoadScene("TrackingQuality", LoadSceneMode.Additive);
    }
    
}
