using UnityEngine;
using System.Collections;
using System.Xml;
using System.Xml.Serialization;

public class Fact
{
    [XmlAttribute("name")]
    public string word;

    [XmlElement("FactA")]
    public string TextA;

    [XmlElement("FactB")]
    public string TextB;

    [XmlElement("FactC")]
    public string TextC;
}

