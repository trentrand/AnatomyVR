using UnityEngine;
using System.Collections;
using System.Xml;
using System.Xml.Serialization;

public class Fact
{
    [XmlAttribute("name")]
    public string word;

    [XmlElement("Fact1")]
    public string TextA;

    [XmlElement("Fact2")]
    public string TextB;

    [XmlElement("Fact3")]
    public string TextC;
}

