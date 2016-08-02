using UnityEngine;
using System.Collections;
using System;

public class InfoStation : MonoBehaviour
{
    TextMesh Info;
    public const string xmlPath = "FactList";
    public FactContainer factCollection;
    BoxCollider triggerCollider;

    void Start()
    {
        Info = GameObject.Find("Info").GetComponent<TextMesh>();
        factCollection = FactContainer.Load(xmlPath);
        triggerCollider = GetComponent<BoxCollider>();
    }

    void OnTriggerEnter(Collider other)
    {
        switch (other.tag)
        {
            case "untagged":
                break;
            case "Heart":
                if (other.gameObject.tag == "heart")
                {
                    Info.text = factCollection.facts[1].TextA;
                }
                break;
            case "Lungs":
                if (other.gameObject.tag == "lungs")
                {
                    Info.text = "Lungs are cool";
                }
                break;
            case "Brain":
                if (other.gameObject.tag == "brain")
                {
                    Info.text = "HELLO WORLD";
                }
                break;
            case "Spine":
                if (other.gameObject.tag == "spine")
                {
                    Info.text = "HELLO WORLD";
                }
                break;
            case "Intestines":
                if (other.gameObject.tag == "intestines")
                {
                    Info.text = "HELLO WORLD";
                }
                break;
            default:
                break;


        }
    }
}