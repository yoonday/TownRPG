using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeName : MonoBehaviour
{
    public GameObject popUpImage; // �˾�
    public InputField inputText;
    public Button CheckButton;

    public void PopUp()
    {
        popUpImage.SetActive(true);
    }


    public void OnCheckButtonClick() // ��ư ���� �� �̸� ���� ������, �̸� �����ϰ� �˾� ����
    {
        if (CheckInput()) // ���� �´��� Ȯ��
        {
            GameManager.Instance.ChangeName(inputText.text); // �̸� �����ؼ� �Ѱ��ֱ� 
            popUpImage.SetActive(false);
        }
    }

    public bool CheckInput() // �̸� �Է� Ȯ��
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