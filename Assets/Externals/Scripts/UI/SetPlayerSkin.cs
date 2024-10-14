using System;
using UnityEngine;

public class SetPlayerSkin : MonoBehaviour
{
    // 디폴트 값으로 기사 스킨 설정
    // 1. 이미지 눌렀을 때 - 팝업 뜨기
    // 2. 팝업에서 스킨 골랐을 때 - 스타트 씬에 해당 스킨 적용
    // 3. 적용된 스킨 - GamaManager에 반영하기
    // 4. 게임 씬에도 적용되게 하기

   
    public GameObject knightSkin; // 기사 스킨 (0번)
    public GameObject wizardSkin; // 위자드 스킨 (1번)
    public GameObject popUpImage; // 팝업

    private int selectedSkin; // 선택한 스킨 저장 

    public void ChooseSkin(int skinIndex)
    {
        selectedSkin = skinIndex;
        SetSkin(skinIndex); // 스킨 변경
        GameManager.Instance.SetSkinIdex(skinIndex); // 선택된 스킨을 GameManager에 저장

        popUpImage.SetActive(false);
    }


    private void SetSkin(int skinIndex)
    {
        knightSkin.SetActive(false); // 모두 비활성화 한 후
        wizardSkin.SetActive(false);

        if (skinIndex == 0) // 기사 스킨 활성화
        {
            knightSkin.SetActive(true);
        }
        else if (skinIndex == 1) // 위자드 스킨 활성화
        {
            wizardSkin.SetActive(true);
        }
    }

    public void PopUp()
    {
        popUpImage.SetActive(true);
    }

    
    
    
}