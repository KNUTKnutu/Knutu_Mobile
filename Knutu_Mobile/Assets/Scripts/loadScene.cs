using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadScene : MonoBehaviour
{
    //게임씬 로드
    public void changeGameScene()
    {
        SceneManager.LoadScene(sceneName.gameScene);
    }

    //대기씬 로드
    public void changeWaitingScene()
    {
        SceneManager.LoadScene(sceneName.waitingScene);
    }

    //로비씬 로드
    public void changeLobbyScene()
    {
        SceneManager.LoadScene(sceneName.lobbyScene);
    }
}
