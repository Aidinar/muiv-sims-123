using System.Xml.Serialization;

[System.Serializable]
public class Answer
{
    [XmlAttribute("tonode")]
    public string nextNode;
    [XmlElement("text")]
    public string text;
}

