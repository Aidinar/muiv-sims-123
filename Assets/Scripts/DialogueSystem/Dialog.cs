using UnityEngine;
using System.Xml.Serialization;
using System.IO;

[XmlRoot("dialogue")]
[System.Serializable]
public class Dialogue
{
    [XmlElement("node")]
    public Node[] nodes;

    public static Dialogue Load(TextAsset _xml)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(Dialogue));
        StringReader reader = new StringReader(_xml.text);
        Dialogue dial = serializer.Deserialize(reader) as Dialogue;
        return dial;
    }
}
