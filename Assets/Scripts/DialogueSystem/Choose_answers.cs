using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Choose_answers : MonoBehaviour
{
    public GameObject ui_text;
    
    private void Start() {      
        ui_text = GameObject.FindWithTag("dialog_text");
    }
    public void Next_text(string text){
        ui_text.GetComponent<TMP_Text>().text = text;
    }
    public void OnActiveObj(GameObject obj){
        obj.SetActive(!obj.activeSelf);
    }
}
