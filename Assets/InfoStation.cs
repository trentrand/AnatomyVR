using UnityEngine;
using System.Collections;
using System;

public class InfoStation : MonoBehaviour
{
    TextMesh Info;
    public const string xmlPath = "FactList";
    public FactContainer factCollection;
    BoxCollider triggerCollider;
    public GrowBubble bubbleBig;
    void Start()
    {
        Info = GameObject.Find("Info").GetComponent<TextMesh>();
        factCollection = FactContainer.Load(xmlPath);
        triggerCollider = GetComponent<BoxCollider>();
        bubbleBig = gameObject.GetComponent<GrowBubble>();
    }
    void start()
    {
        bubbleBig.trueOrFalse = true;
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
                    bubbleBig.trueOrFalse = true;
                }
                break;
            case "Lungs":
                if (other.gameObject.tag == "lungs")
                {
                    Info.text = "Lungs are cool";
                    bubbleBig.trueOrFalse = true;
                }
                break;
            case "Brain":
                if (other.gameObject.tag == "brain")
                {
                    Info.text = "RANDOM LETTERS";
                    bubbleBig.trueOrFalse = true;
                }
                break;
            case "Spine":
                if (other.gameObject.tag == "spine")
                {
                    Info.text = "HELLO WORLD";
                    bubbleBig.trueOrFalse = true;
                }
                break;
            case "Intestines":
                if (other.gameObject.tag == "intestines")
                {
                    Info.text = "HELLO WORLD";
                    bubbleBig.trueOrFalse = true;
                }
                break;
            default:
                break;


        }
    }
}