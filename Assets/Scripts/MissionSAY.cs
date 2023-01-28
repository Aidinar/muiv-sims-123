using UnityEngine;
using System.Collections;

public class MissionSAY : MonoBehaviour
{

    public string missionText;
    private bool _visible = false;
    public bool active = false;

    public GameObject NextBot;
    public bool EndBot = false; // ��������� ��� � ������� ����������
    public int Experience = 10;

    private MissionPLAYER  MP;

    // Use this for initialization
    void Start()
    {
        MP = GameObject.FindGameObjectWithTag("Player").GetComponent<MissionPLAYER>();
    }

    void OnMouseUp()
    {
        if (Input.GetMouseButtonUp(0))
        {
            _visible = true;
        }
    }

    void OnGUI()
    {
        if (_visible)
        {
            GUI.Box(new Rect((Screen.width - 300) / 2, (Screen.height - 300) / 2, 300, 300), "������");
            if (active)
            {
                GUI.Label(new Rect((Screen.width - 300) / 2 + 5, (Screen.height - 300) / 2 + 15, 290, 250), missionText);

                if (GUI.Button(new Rect((Screen.width - 100) / 2, (Screen.height - 300) / 2 + 250, 100, 40), "��"))
                {
                    if (EndBot)
                    {
                        MP.quest = false;
                        MP.Experience += Experience ;
                        MP.MissionText = "";
                        active = false;
                        _visible = false;
                    }
                    else
                    {
                        MP.quest = true;
                        MP.MissionText = missionText;
                        NextBot.GetComponent<MissionSAY>().active = true;
                        active = false;
                        _visible = false;
                    }
                }
            }
            else
            {
                GUI.Label(new Rect((Screen.width - 300) / 2 + 5, (Screen.height - 300) / 2 + 15, 290, 250), "��� ������ ���� �������");

                if (GUI.Button(new Rect((Screen.width - 100) / 2, (Screen.height - 300) / 2 + 250, 100, 40), "��"))
                {
                    _visible = false;
                }
            }
        }
    }
}

                

