using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public PlayerController playerController;

    private CharacterType selectedCharacter; // ���õ� ĳ����

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

    // ĳ���� ���� ���� ����
    public void SetSelectedCharacter(CharacterType characterType)
    {
        selectedCharacter = characterType;
        playerController.SetActiveCharacter(selectedCharacter);
    }

    // ���õ� ĳ���� ��ȯ
    public CharacterType GetSelectedCharacter()
    {
        return selectedCharacter;
    }
}
