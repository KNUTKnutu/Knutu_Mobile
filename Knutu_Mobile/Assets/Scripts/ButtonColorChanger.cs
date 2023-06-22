using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonColorChanger : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public TextMeshProUGUI buttonText;
    public Color normalColor;
    public Color pressedColor;

    // 클릭 버튼을 눌렀을 때
    public void OnPointerDown(PointerEventData _)
    {
        this.OnPointerEvent(true);
    }

    // 클릭 버튼을 뗐을 때
    public void OnPointerUp(PointerEventData _)
    {
        this.OnPointerEvent(false);
    }

    // 클릭 버튼이 눌려있는지에 따라 텍스트의 색깔을 변경
    void OnPointerEvent(bool _isPointerDown)
    {
        this.buttonText.color = _isPointerDown ? this.pressedColor : this.normalColor;
    }
}
