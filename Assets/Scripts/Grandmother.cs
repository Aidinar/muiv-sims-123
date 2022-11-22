using UnityEngine;


public class Grandmother : MonoBehaviour, IInteractable
{
    public string GetDescription()
    {
        return "To talk";
    }

    public void Interact()
    {
        Debug.Log("Talk to grandmother ");
    }
}