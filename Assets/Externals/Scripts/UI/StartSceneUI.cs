using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements.Experimental;



public class StartSceneUI : MonoBehaviour
{
    public InputField inputText;
    public Button JoinButton;
    public int selectedSkin; 

   
   

    private void Start()
    {
        // Join��ư�� ������ OnJoinButtonClick �Լ��� ����
        JoinButton.onClick.AddListener(OnJoinButtonClick);
    }

    public void OnJoinButtonClick() // ��ư ���� �� �̸� ���� ������, �̸� �����ϰ� �ٸ� ������ �̵�
    {
        if (CheckInput()) // ���� �´��� Ȯ��
        {
            GameManager.Instance.PlayerName = inputText.text;// �̸� �����ؼ� �Ѱ��ֱ� 
           
            SceneManager.LoadScene("MainScene"); // �� �̵�
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
