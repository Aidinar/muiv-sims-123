using UnityEngine;


public class Girl : MonoBehaviour, IInteractable
{
	public string GetDescription()
	{
		return "To talk";
	}

	public void Interact()
	{
		Debug.Log("Talk to Girl");
	}
}