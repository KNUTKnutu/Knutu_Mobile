using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetActiveObject : MonoBehaviour
{
    public Button toggleButton;
    public GameObject toggleObject1;
    public GameObject toggleObject2;

    void Start()
    {
        toggleButton.onClick.AddListener(ToggleObjectActiveState);
    }

    // object의 현재 활성 상태를 반대로 설정
    void ToggleObjectActiveState()
    {
        toggleObject1.SetActive(!toggleObject1.activeSelf);
        toggleObject2.SetActive(!toggleObject2.activeSelf);
    }

    // AddListener 해제
    void OnDestroy()
    {
        toggleButton.onClick.RemoveListener(ToggleObjectActiveState);
    }
}
