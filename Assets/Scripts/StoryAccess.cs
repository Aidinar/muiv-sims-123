using UnityEngine;

public class StoryAccess : MonoBehaviour
{
    private static InkStory _storyController = null;
    private static InkStory storyController =>
        _storyController ??
        (_storyController = FindObjectOfType<InkStory>());

    [SerializeField] private InkStory.Enum storyKey;
    public void Play()
    {
        storyController.ActivateStory(storyKey);
    }
}
