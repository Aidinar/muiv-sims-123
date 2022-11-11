using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapUi : MonoBehaviour
{
    [SerializeField] private UnityStandardAssets.Characters.FirstPerson.FirstPersonController characterController;
  public void Activate()
    
    {
        gameObject.SetActive(true);
        characterController.enabled = false;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    public void Deactivate()

    {
        gameObject.SetActive(false);
        characterController.enabled = true;
        //Cursor.visible = true;
        //Cursor.lockState = CursorLockMode.None;
    }
}
