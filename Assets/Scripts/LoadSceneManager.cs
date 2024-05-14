using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadSceneManager : MonoBehaviour
{
    public TMP_InputField playerNameInput;
    public string playerName;

    public void StartGame()
    {
        playerName = playerNameInput.text;

        if (playerName.Length >= 2 && playerName.Length <= 10) // �г��� ���� Ȯ��
        {
            PlayerPrefs.SetString("PlayerName", playerName); // �г��� ����

            if (SceneManager.GetActiveScene().name != "MainScene")
            {
                // ���� ���� MainScene�� �ƴ϶��
                SceneManager.LoadScene("MainScene"); // �� �̵�
            }
            else
            {
                // �̹� MainScene�� ���, �г��� ���� �޴��� ����
                gameObject.SetActive(false);
            }
        }
        else
        {
            Debug.Log("�г����� 2�� �̻� 10�� ���Ϸ� �Է��ϼ���.");
        }
    }
}
