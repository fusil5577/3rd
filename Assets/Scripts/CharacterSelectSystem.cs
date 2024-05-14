using UnityEngine;
using UnityEngine.UI;

public class CharacterSelection : MonoBehaviour
{
    public GameObject player;
    public GameObject selectMenu;
    public GameObject nickNameInput;

    void Start()
    {
        selectMenu.SetActive(false);
    }

    public void ShowSelectMenu()
    {
        nickNameInput.SetActive(false);
        player.SetActive(false);
        selectMenu.SetActive(true);
    }
}