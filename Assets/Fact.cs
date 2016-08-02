using UnityEngine;
using System.Collections;
using System.Xml;
using System.Xml.Serialization;

public class Fact
{
    [XmlAttribute("name")]
    public string word;

    [XmlElement("Fact1")]
    public string Text1;

    [XmlElement("Fact2")]
    public string Text2;

    [XmlElement("Fact3")]
    public string Text3;
}

