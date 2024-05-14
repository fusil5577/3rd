using UnityEngine;

public class ShowCharacterSelectMenu : MonoBehaviour
{
    public GameObject characterSelectMenu;
    public GameObject nickNameChangeMenu;
    public GameObject guestListUI;

    // �޴��� �����ִ� �Լ�
    private void ShowMenu(GameObject menu)
    {
        // ���� �޴��� �̹� Ȱ��ȭ�Ǿ� �ִٸ� ��Ȱ��ȭ
        if (menu.activeSelf)
        {
            menu.SetActive(false);
            return;
        }

        // "Menu" �±׸� ���� ������Ʈ���� ã��
        GameObject[] menuObjects = GameObject.FindGameObjectsWithTag("Menu");

        // �ϳ��� Ȱ��ȭ�Ǿ� �ִٸ� �ƹ� �ϵ� ����
        foreach (GameObject menuObject in menuObjects)
        {
            if (menuObject.activeSelf && menuObject != menu) // GuestListUI�� ������ �ʾƼ� ���ܽ�Ŵ
            {
                return;
            }
        }

        // ��� "Menu" �±׸� ���� ������Ʈ�� ��Ȱ��ȭ�Ǿ� �ִٸ� �޴��� Ȱ��ȭ
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
