using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonColorChanger : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private TextMeshProUGUI buttonText;
    [SerializeField] private Color normalColor;
    [SerializeField] private Color pressedColor;

    // 클릭 버튼을 눌렀을 때
    public void OnPointerDown(PointerEventData _eventData)
    {
        this.buttonText.color = pressedColor;
    }

    // 클릭 버튼을 땠을 때
    public void OnPointerUp(PointerEventData _eventData)
    {
        this.buttonText.color = normalColor;
    }
}
