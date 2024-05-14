using UnityEngine;

public class NPCInteraction : MonoBehaviour
{
    public GameObject panel;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // 플레이어가 들어왔을 때
        {
            panel.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // 플레이어가 벗어났을 때
        {
            panel.SetActive(false);
        }
    }
}
