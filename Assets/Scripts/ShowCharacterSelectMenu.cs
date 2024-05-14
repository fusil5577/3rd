using UnityEngine;

public class ShowCharacterSelectMenu : MonoBehaviour
{
    public GameObject characterSelectMenu;
    public GameObject nickNameChangeMenu;
    public GameObject guestListUI;

    // 메뉴를 보여주는 함수
    private void ShowMenu(GameObject menu)
    {
        // 만약 메뉴가 이미 활성화되어 있다면 비활성화
        if (menu.activeSelf)
        {
            menu.SetActive(false);
            return;
        }

        // "Menu" 태그를 가진 오브젝트들을 찾기
        GameObject[] menuObjects = GameObject.FindGameObjectsWithTag("Menu");

        // 하나라도 활성화되어 있다면 아무 일도 없음
        foreach (GameObject menuObject in menuObjects)
        {
            if (menuObject.activeSelf && menuObject != menu) // GuestListUI는 가리지 않아서 제외시킴
            {
                return;
            }
        }

        // 모든 "Menu" 태그를 가진 오브젝트가 비활성화되어 있다면 메뉴를 활성화
        menu.SetActive(true);
    }

    public void ShowcharacterSelectMenu()
    {
        ShowMenu(characterSelectMenu);
    }

    public void ShowNickNameChangeMenu()
    {
        ShowMenu(nickNameChangeMenu);
    }

    public void ShowGuestListUI()
    {
        ShowMenu(guestListUI);
    }
}
