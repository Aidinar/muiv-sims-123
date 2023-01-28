
using UnityEngine;
using System.Collections;

public class MissionPLAYER : MonoBehaviour {
    public bool quest;
    public string MissionText;
  

    public int Experience;

    void OnGUI()
    {
        GUI.Label
         (new Rect(Screen.width - 100, 5, 100,30), "Опыт:" + Experience);

        if (quest)
        {
            GUI.Label(new Rect(5, 5, 300, 100), "Текущее задание: " + MissionText);
            
        }
    }
}

