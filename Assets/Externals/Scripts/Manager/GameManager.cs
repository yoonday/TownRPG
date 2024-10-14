using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Pool;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    
    public string PlayerName { get; set; } // 플레이어 이름 저장
    public int PlayerSkinIndex {  get; set; } // 플레이어 스킨 저장



    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // 스타트씬에서 저장한 내용 유지되도록
        }    
    }

    public void ChangeName(string name)
    {
        PlayerName = name;
        // 메인 씬 UI에서 update네임 찾아오기
    }

    public void SetSkinIdex(int skinIndex)
    {
        PlayerSkinIndex = skinIndex;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
