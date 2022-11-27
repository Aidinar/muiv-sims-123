using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterDialogue : MonoBehaviour
{
    [SerializeField] private string dialogueText;

    [SerializeField] private InstantiateDialogue dialoguePanel;
   
    private void Start()
    {
        if (!dialoguePanel)
            dialoguePanel = FindObjectOfType<InstantiateDialogue>();
    }
    public void ShowDialogue()
    {
        print(dialoguePanel);
        dialoguePanel.Activate(dialogueText);

    }
}
