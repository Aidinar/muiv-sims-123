using UnityEngine;


public class Politician : MonoBehaviour, IInteractable
{
	public string GetDescription()
	{
		return "To talk";
	}

	public void Interact()
	{
		Debug.Log("Talk to Politician");
	}
}