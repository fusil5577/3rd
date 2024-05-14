using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueHandler : MonoBehaviour
{
    public GameObject npcDialogue;
    public GameObject npcDialogueBtn;

    public void ShowDialogue()
    {
        npcDialogueBtn.SetActive(false);
        npcDialogue.SetActive(true);
    }

    public void CloseDialogue()
    {
        npcDialogueBtn.SetActive(true);
        npcDialogue.SetActive(false);
        this.gameObject.SetActive(false);
    }
}
