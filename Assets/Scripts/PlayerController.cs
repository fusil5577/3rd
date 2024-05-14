using System;
using UnityEngine;

public enum CharacterType
{
    Penguin,
    Wizzard,
}

public class PlayerController : MonoBehaviour
{
    public GameObject[] characters;

    void Start()
    {
        GameManager.instance.playerController = this;
        CharacterLoad();
    }

    public void CharacterLoad()
    {
        // GameManager에서 선택된 캐릭터 가져오기
        CharacterType selectedCharacter = GameManager.instance.GetSelectedCharacter();

        // Penguin은 기본 설정
        if (selectedCharacter == null)
        {
            selectedCharacter = CharacterType.Penguin;
        }

        // 선택한 캐릭터를 활성화
        SetActiveCharacter(selectedCharacter);
    }

    // 캐릭터를 활성화
    public void SetActiveCharacter(CharacterType characterType)
    {
        // 전부 비활성화
        foreach (GameObject character in characters)
        {
            character.SetActive(false);
        }

        // 선택한 것만 활성화
        characters[(int)characterType].SetActive(true);
    }
}
