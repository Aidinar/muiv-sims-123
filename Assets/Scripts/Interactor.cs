using UnityEngine;
using UnityEngine.Events;



public class NewBehaviourScript : MonoBehaviour, IInteractable
{
    [SerializeField] private string actionText;

    [SerializeField] private string onInteraction;

    public string GetDescription()
    {
        return actionText;
    }
    public void Intract()
    {
        onInteraction.Invoke();
    }
}
