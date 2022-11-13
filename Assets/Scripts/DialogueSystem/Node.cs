using System.Xml.Serialization;

[System.Serializable]
public class Node
{
    [XmlAttribute("name")]
    public string name;

    [XmlArray("npc")]
    [XmlArrayItem("text")]
    public string[] texts;

    [XmlArray("answers")]
    [XmlArrayItem("answer")]
    public Answer[] answers;
}
