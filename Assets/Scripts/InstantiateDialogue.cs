using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class InstantiateDialogue : MonoBehaviour
{
    [SerializeField] private Dialogue dialogue;
    [SerializeField] private GameObject window;
    [SerializeField] private text_animation textAnimation;
    [SerializeField] private Button nextButton;
    private TMP_Text nextButtonText;
    [SerializeField] private GameObject[] answerButtonObjects;
    private TMP_Text[] answerTexts;
    private int nextPhraseId;
    private Node activeNode;

	public void Awake()
	{
        answerTexts = new TMP_Text[answerButtonObjects.Length];
		for (int i = 0; i < answerButtonObjects.Length; i++)
        {
            answerTexts[i] = answerButtonObjects[i]
                             .GetComponentInChildren<TMP_Text>();
		}
        nextButtonText = nextButton.GetComponentInChildren<TMP_Text>();
    }

	public void Activate(string nodeName)
    {
        if (nodeName == "")
        {
            window.SetActive(false);
            return;
        }
        foreach (var node in dialogue.nodes)
        {
            if (node.name == nodeName)
            {
                Activate(node);
                return;
            }
		}
        Debug.LogWarning($"Не найден узел диалога {nodeName}");
	}

    public void Activate(Node node)
    {
        nextPhraseId = 0;
        activeNode = node;
        textAnimation.stop_animation_textUi();
        Next();
    }
    public void Next()
    {
        if (textAnimation.enabled)
        {
            textAnimation.stop_animation_textUi();
            nextButtonText.text = "Далее";
            return;
        }
        if (nextPhraseId < activeNode.phrases.Length)
        {
            window.SetActive(true);
            foreach (var obj in answerButtonObjects) obj.SetActive(false);
            textAnimation.ShowText(activeNode.phrases[nextPhraseId++]);
            if (activeNode.phrases.Length == nextPhraseId)
            {
                int i = answerButtonObjects.Length;
                if (activeNode.answers.Length > i)
                {
                    Debug.LogWarning($"Слишком много ответов в узле диалога {activeNode.name}");
                } else {
                    while (i > activeNode.answers.Length) {
                        answerButtonObjects[--i].SetActive(false);
					}
                }
                while (i > 0)
                {
                    answerButtonObjects[--i].SetActive(true);
                    answerTexts[i].text = activeNode.answers[i].text;
				}
                nextButtonText.text = "Завершить";
            }
            else {
                nextButtonText.text = "Показать";
			}
        } else {
            window.SetActive(false);
		}
	}

    public void Answer(int answer_id)
    {
        print(activeNode.name);
        print(activeNode.answers.Length);
        foreach (var answer in activeNode.answers) print(answer.text);
        Activate(activeNode.answers[answer_id].target_node_name);
	}
}
