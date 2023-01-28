using UnityEngine;
using Ink.Runtime;
using TMPro;

public class DialogUI : MonoBehaviour
{
    [SerializeField] TMP_Text dialogText;
    [SerializeField] TMP_Text nameText;
    public void Activate(Story story)
    {
        gameObject.SetActive(true);
        dialogText.text = story.currentText;
        nameText.text = story.currentTags[0];
    }
    public void Deactivate(Story story)
    {
        gameObject.SetActive(false);
    }
}
