using UnityEngine;
using Ink.Runtime;
using System.Collections.Generic;
public class InkStory : MonoBehaviour
{
    [SerializeField] TextAsset inkAsset;
    [SerializeField] DialogUI dialogUI;


    public enum Enum
    {
        ДевушкаПарк,
        БабушкаПарк,
    }
    private static Dictionary<Enum, string> storyDict =
        new Dictionary<Enum, string>()
    {
        { Enum.БабушкаПарк, "Grandma"},
        { Enum.ДевушкаПарк, "Girl"},
    };

    Story story;
    public void Start()
    {
        story = new Story(inkAsset.text);
    }
    
    public void ActivateStory(Enum storyKey)
    {
        if (storyDict.TryGetValue(storyKey, out var storyPath))
        {
            story.ChoosePathString(storyPath);
            if (story.canContinue)
            {
                story.Continue();
            }
            dialogUI.Activate(story);
        } else {
            Debug.LogWarning($"Для ключа {storyKey} нет записи в StoryDict");
        }
    }
}
