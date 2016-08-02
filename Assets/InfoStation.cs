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
                if (other.gameObject.tag == "Heart")
                {
                    Info.text = factCollection.facts[1].TextA;
                }
                break;
            case "Lungs":
                if (other.gameObject.tag == "Lungs")
                {
                    Info.text = factCollection.facts[2].TextA;
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