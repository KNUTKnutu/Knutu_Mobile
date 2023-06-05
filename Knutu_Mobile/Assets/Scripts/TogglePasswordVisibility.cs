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
        // 토글에 이벤트 리스너 추가
        passwordToggle.onValueChanged.AddListener(UpdatePasswordVisibility);

        //초기 contentType 설정 (숨김상태)
        passwordToggle.isOn = true;
        passwordInputField.contentType = passwordType;
    }

    // 토글 값이 변경될 때 호출되는 메소드
    void UpdatePasswordVisibility(bool _isChecked)
    {
        if (_isChecked)
            // 토글이 선택되면 비밀번호를 숨김
            passwordInputField.contentType = passwordType;
        else
            // 토글이 해제되면 비밀번호를 표시
            passwordInputField.contentType = standardType;

        //contentType이 변경되면 UI갱신
        passwordInputField.ForceLabelUpdate();
    }

    // AddListener 해제
    void OnDestroy()
    {
        passwordToggle.onValueChanged.RemoveListener(UpdatePasswordVisibility);
    }
}
