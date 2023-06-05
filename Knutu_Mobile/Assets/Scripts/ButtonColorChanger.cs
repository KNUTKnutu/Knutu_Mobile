using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonColorChanger : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public TextMeshProUGUI buttonText;
    public Color normalColor;
    public Color pressedColor;

    // 클릭 버튼을 눌렀을 때
    public void OnPointerDown(PointerEventData _eventData)
    {
        this.buttonText.color = this.pressedColor;
    }

    // 클릭 버튼을 땠을 때
    public void OnPointerUp(PointerEventData _eventData)
    {
        this.buttonText.color = this.normalColor;
    }
}
