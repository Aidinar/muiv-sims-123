using UnityEngine;


public class Guy : MonoBehaviour, IInteractable
{
	public string GetDescription()
	{
		return "To talk";
	}

	public void Interact()
	{
		Debug.Log("Talk to Guy");
	}
}