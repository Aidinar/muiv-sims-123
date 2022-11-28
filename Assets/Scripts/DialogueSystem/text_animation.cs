using System.Collections;
using UnityEngine;
using TMPro;


public class text_animation : MonoBehaviour
{
    string text_ui_element; 
    public GameObject buttons;
    void Start()
    {
        text_ui_element = GetComponent<TMP_Text>().text;
        StartCoroutine(animation_text_ui(text_ui_element));
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {           
            stop_animation_textUi();
        }
    }
    IEnumerator animation_text_ui(string stext)
    {
        int i = 0;
        bool end = false;
        while (i <= stext.Length)
        {
            if (i + 1 <= stext.Length)
            {
                if (stext[i] == '<' && stext[i + 1] == 'c')
                {
                    i += 15;
                    end = true;
                }
                else if (stext[i] == '<' && stext[i + 1] == '/')
                {
                    i += 8;
                    end = false;
                }
            }
            if (end)
            {
                GetComponent<TMP_Text>().text = stext.Substring(0, i) + "</color>";
            }
            else
                GetComponent<TMP_Text>().text = stext.Substring(0, i);
            i++;

            yield return new WaitForSeconds(0.05f);
        }
        stop_animation_textUi();
    }
    void stop_animation_textUi()
    {
        StopAllCoroutines();
        GetComponent<TMP_Text>().text = text_ui_element;
        buttons.SetActive(true);        
    }

    public void next_text_func(GameObject next_text)
    {
        gameObject.SetActive(false);
        next_text.SetActive(true);
        
    }
}
