using UnityEngine;
using UnityEngine.UI;

public class InstantiateDialogue : MonoBehaviour
{
    public GameObject window;
    public void Activate(string text)
    {
        Debug.LogWarning($"������� Activate ��������!\n�����: Activate({text});");
    }
    
    public void Deactivate()
    {
        window.SetActive(!window.activeSelf);
    }
    
}
