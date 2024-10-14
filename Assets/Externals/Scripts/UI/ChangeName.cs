using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeName : MonoBehaviour
{
    public GameObject popUpImage; // 팝업
    public InputField inputText;
    public Button CheckButton;

    public void PopUp()
    {
        popUpImage.SetActive(true);
    }


    public void OnCheckButtonClick() // 버튼 실행 → 이름 조건 맞으면, 이름 저장하고 팝업 끄기
    {
        if (CheckInput()) // 조건 맞는지 확인
        {
            GameManager.Instance.ChangeName(inputText.text); // 이름 저장해서 넘겨주기 
            popUpImage.SetActive(false);
        }
    }

    public bool CheckInput() // 이름 입력 확인
    {
        string inputName = inputText.text;
        if (inputName.Length >= 2 && inputName.Length <= 10)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}