using UnityEngine;
using UnityEngine.Events;



public class Interactor : MonoBehaviour, IInteractable
{
    [SerializeField] private string actionText;

    [SerializeField] private UnityEvent onInteraction;

    public string GetDescription()
    {
        return actionText;
    }
    public void Interact()
    {
        onInteraction.Invoke();
    }
}
