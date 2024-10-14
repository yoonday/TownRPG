using System;
using UnityEngine;
using UnityEngine.UI;

public class MainSceneUI : MonoBehaviour
{
    public Text PlayerNameText; // UI Text 받을 것

    public GameObject knightSkin;
    public GameObject wizardSkin;

    private void Start()
    {
        UpdateName();

        int skinIndex = GameManager.Instance.PlayerSkinIndex;
        SetSkin(skinIndex); // 스킨 설정
    }

    public void UpdateName()
    {
        PlayerNameText.text = GameManager.Instance.PlayerName; // GameManager에서 받아옴
    }

    private void SetSkin(int skinIndex) // StartScene이랑 동일함
    {
        knightSkin.SetActive(false); 
        wizardSkin.SetActive(false);

        if (skinIndex == 0)
        {
            knightSkin.SetActive(true);
        }
        else if (skinIndex == 1)
        {
            wizardSkin.SetActive(true);
        }
    }
}