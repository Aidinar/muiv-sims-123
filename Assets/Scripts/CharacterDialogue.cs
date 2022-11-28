using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterDialogue : MonoBehaviour
{
    [SerializeField] private string dialogueNode;
    public void ShowDialogue()
    {
        Dialogue.Begin(dialogueNode);
    }
}
