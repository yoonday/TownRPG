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
        // Join버튼을 누르면 OnJoinButtonClick 함수를 실행
        JoinButton.onClick.AddListener(OnJoinButtonClick);
    }

    public void OnJoinButtonClick() // 버튼 실행 → 이름 조건 맞으면, 이름 저장하고 다른 씬으로 이동
    {
        if (CheckInput()) // 조건 맞는지 확인
        {
            GameManager.Instance.PlayerName = inputText.text;// 이름 저장해서 넘겨주기 
           
            SceneManager.LoadScene("MainScene"); // 씬 이동
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
