using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Pool;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    
    public string PlayerName { get; set; } // �÷��̾� �̸� ����
    public int PlayerSkinIndex {  get; set; } // �÷��̾� ��Ų ����



    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // ��ŸƮ������ ������ ���� �����ǵ���
        }    
    }

    public void ChangeName(string name)
    {
        PlayerName = name;
        // ���� �� UI���� update���� ã�ƿ���
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
