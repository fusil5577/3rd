using UnityEngine;

public class SelectMenu : MonoBehaviour
{
    public GameObject player;
    public GameObject penguin;
    public GameObject wizzard;
    public GameObject SelectMunu;
    public GameObject nickNameInput;

    // Select1 버튼을 클릭했을 때
    public void OnSelect1Clicked()
    {
        SelectMunu.SetActive(false);
        if (player != null)
        {
            nickNameInput.SetActive(true);
            player.SetActive(true);
            penguin.SetActive(true);
            wizzard.SetActive(false);
        }
        // Penguin 선택
        GameManager.instance.SetSelectedCharacter(CharacterType.Penguin);
    }

    // Select2 버튼을 클릭했을 때
    public void OnSelect2Clicked()
    {
        SelectMunu.SetActive(false);
        if (player != null)
        {
            nickNameInput.SetActive(true);
            player.SetActive(true);
            penguin.SetActive(false);
            wizzard.SetActive(true);
        }
        // Wizzard 선택
        GameManager.instance.SetSelectedCharacter(CharacterType.Wizzard);
    }
}