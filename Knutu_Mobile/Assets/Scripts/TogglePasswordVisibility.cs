using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TogglePasswordVisibility : MonoBehaviour
{
    public TMP_InputField passwordInputField;
    public Toggle passwordToggle;
    const TMP_InputField.ContentType standardType = TMP_InputField.ContentType.Standard;
    const TMP_InputField.ContentType passwordType = TMP_InputField.ContentType.Password;

    void Start()
    {
        passwordToggle.onValueChanged.AddListener(UpdatePasswordVisibility);

        // 초기 contentType 설정 (숨김상태)
        passwordToggle.isOn = true;
        passwordInputField.contentType = passwordType;
    }

    // 토글 값이 변경될 때 호출되는 메소드
    void UpdatePasswordVisibility(bool _isChecked)
    {
        // 토글 값에 따라 비밀번호 표시 여부 결정
        passwordInputField.contentType = _isChecked ? passwordType : standardType;

        // contentType이 변경되면 UI 갱신
        passwordInputField.ForceLabelUpdate();
    }

    // AddListener 해제
    void OnDestroy()
    {
        passwordToggle.onValueChanged.RemoveListener(UpdatePasswordVisibility);
    }
}
