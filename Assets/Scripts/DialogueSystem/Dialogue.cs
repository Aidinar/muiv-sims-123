using System;
using UnityEngine;


[CreateAssetMenu()]
public class Dialogue : ScriptableObject
{
	private static InstantiateDialogue manager;
	public static void Begin(string nodeName)
	{
		if (!manager)
		{
			manager = FindObjectOfType<InstantiateDialogue>();
		}
		if (manager)
		{
			manager.Activate(nodeName);
		}
	}
	
	public Node[] nodes;
}

[Serializable]
public struct Node
{
	public string name;
	public string[] phrases;
	public Answer[] answers;
}

[Serializable]
public struct Answer
{
	public string text;
	public string target_node_name;
}