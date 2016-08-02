using UnityEngine;
using System.Collections;
using System;

public class InfoStation : MonoBehaviour
{
    TextMesh Info;
    public const string xmlPath = "FactList";
    public FactContainer factCollection;

    void Start()
    {
        Info = GameObject.Find("Info").GetComponent<TextMesh>();
        factCollection = FactContainer.Load(xmlPath);
    }

    void OnTriggerEnter(Collider other)
    {
        
        switch (other.tag)
        {
            case "nothing":
                break;
            case "Heart":
                if (other.gameObject.tag == "Heart")
                {
                    Info.text = factCollection.facts[1].Text1;
                }
                break;
            case "Lungs":
                if (other.gameObject.tag == "Lungs")
                {
                    Info.text = factCollection.facts[2].Text1;
                }
                break;
            case "Brain":
                if (other.gameObject.tag == "Brain")
                {
                    Info.text = "HELLO WORLD";
                }
                break;
            case "Spine":
                if (other.gameObject.tag == "Spine")
                {
                    Info.text = "HELLO WORLD";
                }
                break;
            case "Intestines":
                if (other.gameObject.tag == "Intestines")
                {
                    Info.text = "HELLO WORLD";
                }
                break;
            default:
                break;
        }
    }
}