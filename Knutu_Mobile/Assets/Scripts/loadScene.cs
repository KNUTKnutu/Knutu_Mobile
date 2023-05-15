using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void ChangeScene(string SCENE_NAME)
    {
        string scenePath = constantsLib.GetScenePath(SCENE_NAME);
        SceneManager.LoadScene(scenePath);
        //SceneManager.LoadScene(SCENE_NAME);
    }
    ////게임씬 로드
    //public void ChangeGameScene()
    //{
    //    Debug.Log("스트링 : " + constantsLib.GAME_SCENE);
    //    Debug.Log("GetType() : " + constantsLib.GAME_SCENE.GetType());
    //    Debug.Log("GetType().Name : " + constantsLib.GAME_SCENE.GetType().Name);
    //    Debug.Log("GetType().FullName : " + constantsLib.GAME_SCENE.GetType().FullName);
    //    SceneManager.LoadScene(constantsLib.GAME_SCENE);
    //}

    ////대기씬 로드
    //public void ChangeWaitingScene()
    //{
    //    SceneManager.LoadScene(constantsLib.INTRO_SCENE);
    //}

    ////로비씬 로드
    //public void ChangeLobbyScene()
    //{
    //    SceneManager.LoadScene(constantsLib.LOBBY_SCENE);
    //}
}
