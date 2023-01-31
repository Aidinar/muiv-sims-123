using System.Collections;
using UnityEngine;
using TMPro;


public class text_animation : MonoBehaviour
{
    [SerializeField] private TMP_Text textComponent;
    private string stext;
    private Coroutine coroutine;
    void Awake()
    {
        textComponent = GetComponent<TMP_Text>();
        enabled = false;
    }
    public void ShowText(string text)
    {
        stext = text;
        enabled = true;
        coroutine = StartCoroutine(animation_text_ui());
	}
    public void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {           
            stop_animation_textUi();
        }
    }
    private IEnumerator animation_text_ui()
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
                textComponent.text = stext.Substring(0, i) + "</color>";
            }
            else
            {
                textComponent.text = stext.Substring(0, i);
            }
            i++;

            yield return new WaitForSeconds(0.05f);
        }
        stop_animation_textUi();
    }
    public void stop_animation_textUi()
    {
        if (coroutine != null) StopCoroutine(coroutine);
        if (textComponent)
            textComponent.text = stext;
        enabled = false;
    }
}
