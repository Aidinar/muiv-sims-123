using UnityEngine;
using UnityEngine.UI;

public class InstantiateDialogue : MonoBehaviour
{
    public GameObject window;
    public void Deactivate()
    {
        window.SetActive(!window.activeSelf);
    }
    
}
