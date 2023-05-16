using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour{
    public void ChangeScene(string SCENE_NAME)    {
        string scenePath = constantsLib.GetScenePath(SCENE_NAME);
        if (scenePath == null)
            throw new NullReferenceException("Scene path is null.");
        SceneManager.LoadScene(scenePath);
    }
}
