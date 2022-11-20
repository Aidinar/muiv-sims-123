using UnityEngine;


public class Granny : MonoBehaviour, IInteractable
{
	public string GetDescription()
	{
		return "Поговорить";
	}

	public void Interact()
	{
		Debug.Log("Говорим с девушкой");
	}
}