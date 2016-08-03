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
        bubbleBig = GameObject.Find("Sphere").GetComponent<GrowBubble>();

    }

    void OnTriggerEnter(Collider other)
    {

        Debug.Log(other.tag);

        switch (other.tag)
        {
            case "Untagged":
                bubbleBig.trueOrFalse = false;
                break;
            case "Heart":
                Info.text = factCollection.facts[1].TextA;
                bubbleBig.trueOrFalse = true;

                break;
            case "Lungs":

                Info.text = factCollection.facts[2].TextA;
                bubbleBig.trueOrFalse = true;

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

            // TODO: check if hands are colliding, and if so dont make the spehere smaller
            default:

                bubbleBig.trueOrFalse = false;
                break;


        }
    }
}