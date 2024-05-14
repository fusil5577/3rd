using UnityEngine;
using System;
using TMPro;

public class TimeDisplay : MonoBehaviour
{
    public TMP_Text timeText;

    void Update()
    {
        // 현재 시간을 받아옵니다.
        DateTime currentTime = DateTime.Now;

        // 시간과 분까지만 표시합니다.
        string timeString = string.Format("{0:00}:{1:00}", currentTime.Hour, currentTime.Minute);

        // 텍스트 오브젝트에 반영합니다.
        timeText.text = timeString;
    }
}