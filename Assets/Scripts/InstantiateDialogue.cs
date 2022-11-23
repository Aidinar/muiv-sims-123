using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InstantiateDialogue : MonoBehaviour
{
    [SerializeField] private TextAsset dialogueAsset;
    [SerializeField] private TMP_Text nextButtonText;
    public GameObject window;
    public TMP_Text text;

    private Dialogue dialogueData;

    private int nextTextNumber = 0;
    private Node _activeNode;
    private Node ActiveNode { get { return _activeNode; }
        set { _activeNode = value; nextTextNumber = 0; } }
 
	private void Awake()
	{
        dialogueData = Dialogue.Load(dialogueAsset);
        foreach (var node in dialogueData.nodes)
        {
            foreach (var line in node.texts) print(line);
            foreach (var answer in node.answers) print(answer);
        }
    }

	public void Activate(string nodeName)
    {
        foreach (var savedNode in dialogueData.nodes)
        {
            if (savedNode.name == nodeName)
            {
                window.SetActive(true);
                ActiveNode = savedNode;
                Next();
                return;
			}
		}
        Debug.LogError($"{nodeName} не найден в {dialogueAsset.name}");
    }

    public void Next()
    {
        if (ActiveNode == null || ActiveNode.texts.Length <= nextTextNumber)
        {
            Deactivate();
            return;
        }
        text.text = ActiveNode.texts[nextTextNumber++];
        if (ActiveNode.texts.Length == nextTextNumber)
        {
            nextButtonText.text = "Закрыть";
            // TODO добавить создание кнопок ответов
        } else {
            nextButtonText.text = "Следующий";
        }
    }

    public void Deactivate()
    {
        window.SetActive(false);
    }

    public void ChooseAnswer(int id)
    {
        print($"Выбран ответ {id}");
	}
}
