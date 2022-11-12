using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomMap : MonoBehaviour, IInteractable
{
	public MapUi map_ui;
	public string GetDescription() 
	{
		return "����� [E] ����� ������� �����";
	}
	public void Interact()
	{
		map_ui.Activate();
	}
}
