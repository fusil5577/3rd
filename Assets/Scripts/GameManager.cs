using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public PlayerController playerController;

    private CharacterType selectedCharacter; // 선택된 캐릭터

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // 캐릭터 선택 정보 설정
    public void SetSelectedCharacter(CharacterType characterType)
    {
        selectedCharacter = characterType;
        playerController.SetActiveCharacter(selectedCharacter);
    }

    // 선택된 캐릭터 반환
    public CharacterType GetSelectedCharacter()
    {
        return selectedCharacter;
    }
}
