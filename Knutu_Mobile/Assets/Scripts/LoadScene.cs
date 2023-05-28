using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour{
    public void ChangeScene(string _SCENE_NAME)    {
        string scenePath = constantsLib.GetScenePath(_SCENE_NAME);
        if (scenePath == null)
            throw new NullReferenceException("Scene path is null.");
        SceneManager.LoadScene(scenePath);
    }
}
