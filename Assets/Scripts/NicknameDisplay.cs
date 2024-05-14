using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NicknameDisplay : MonoBehaviour
{
    public Text playerNameText;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        string playerName = PlayerPrefs.GetString("PlayerName");
        playerNameText.text = playerName;
    }
}
