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
        SceneManager.LoadScene("URP", LoadSceneMode.Additive);
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
        SceneManager.LoadScene("TrackingQuality", LoadSceneMode.Additive); // Reloading TrackingQuality to ensure it's on the top
    }

    public void ToggleMovementJoystick()
    {
        const string sceneName = "MoveJoystick";
        bool loaded = IsSceneLoaded(sceneName);
        if (loaded) SceneManager.UnloadSceneAsync(sceneName);
        else SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);
    }


    /// <summary>
    /// Gets the currently loaded instance of SceneManagement
    /// </summary>
    /// <returns>The SceneManagement instance</returns>
    public static SceneManagement GetInstance()
    {
        var scmgo = GameObject.Find("SceneManagement");
        if (scmgo is null) return null;
        var scm = scmgo.GetComponent<SceneManagement>();
        return scm;
    }
    
    /// <summary>
    /// This checks if a scene is already loaded based on the name of the scene
    /// </summary>
    /// <param name="name">The name of the scene excluding the file extension</param>
    /// <returns>Whether or not the scene is already loaded</returns>
    private bool IsSceneLoaded(string name)
    {
        // Loops through all loaded scenes, this is probably dumb and slow!
        for (int i = 0; i < SceneManager.sceneCount; i++)
            if (SceneManager.GetSceneAt(i).name == name) return true;
        return false;
    }
    
}
