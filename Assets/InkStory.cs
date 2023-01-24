using UnityEngine;
using Ink.Runtime;
public class InkStory : MonoBehaviour
{
    [SerializeField] TextAsset inkAsset;
    Story story;
    public void Start()
    {
        story = new Story(inkAsset.text);
    }
    
    public void ActivateStory(StoryEnum storyKey)
    {
        if (story.canContinue)
        {
            story.Continue();
        }
        Debug.Log($"text: {story.currentText}");
        foreach (var choice in story.currentChoices)
            Debug.Log($"choice: {choice.text}");
    }
}
