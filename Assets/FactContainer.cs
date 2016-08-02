using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

[XmlRoot("FactList")]
public class FactContainer
{

    [XmlArray("Facts")]
    [XmlArrayItem("Fact")]
    public List<Fact> facts = new List<Fact>(); // Initialize word list

    // Utility function to load our WordList XML
    public static FactContainer Load(string path)
    {
        // Load the XML file from the passed path
        TextAsset _xml = Resources.Load<TextAsset>(path);

        // Initialize a serializer
        XmlSerializer serializer = new XmlSerializer(typeof(FactContainer));

        // Initialize string reader using our loaded XML file
        StringReader reader = new StringReader(_xml.text);

        // Initialize our WordContainer from serialized XML 
        FactContainer Facts = serializer.Deserialize(reader) as FactContainer;

        // Close the reader to save resources
        reader.Close();

        // Return WordContainer <words>
        return Facts;
    }
}