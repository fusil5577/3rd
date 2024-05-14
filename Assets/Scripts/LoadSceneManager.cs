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

        if (playerName.Length >= 2 && playerName.Length <= 10) // 닉네임 길이 확인
        {
            PlayerPrefs.SetString("PlayerName", playerName); // 닉네임 저장

            if (SceneManager.GetActiveScene().name != "MainScene")
            {
                // 현재 씬이 MainScene이 아니라면
                SceneManager.LoadScene("MainScene"); // 씬 이동
            }
            else
            {
                // 이미 MainScene인 경우, 닉네임 변경 메뉴를 닫음
                gameObject.SetActive(false);
            }
        }
        else
        {
            Debug.Log("닉네임을 2자 이상 10자 이하로 입력하세요.");
        }
    }
}
