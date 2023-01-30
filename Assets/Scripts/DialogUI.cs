using UnityEngine;
using Ink.Runtime;
using TMPro;

public class DialogUI : MonoBehaviour
{
    [SerializeField] TMP_Text dialogText;
    [SerializeField] TMP_Text nameText;
    [SerializeField] GameObject choices;
    [SerializeField] TMP_Text choice1;
    [SerializeField] TMP_Text choice2;


    private string GetPortraitName(Story story)
    {
        return story.currentTags[0];
    }

    public void Activate(Story story)
    {
        gameObject.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        dialogText.text = story.currentText;
        nameText.text = GetPortraitName(story);

        if (story.currentChoices.Count > 0)
        {
            choices.SetActive(true);
            choice1.text = story.currentChoices[0].text;
            if (story.currentChoices.Count > 1)
            {
                choice2.text = story.currentChoices[1].text;
                choice2.transform.parent.gameObject.SetActive(true);
            } else {
                choice2.transform.parent.gameObject.SetActive(false);
            }
        } else {
            choices.SetActive(false);
        }
    }
    public void Deactivate(Story story)
    {
        gameObject.SetActive(false);
    }
}
