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
    public string broadCaster = "none";

    void Start()
    {
        Info = GameObject.Find("Info").GetComponent<TextMesh>();
        factCollection = FactContainer.Load(xmlPath);
        triggerCollider = GetComponent<BoxCollider>();
        bubbleBig = GameObject.Find("Animation Orb").GetComponent<GrowBubble>();

    }

    void OnTriggerEnter(Collider other)
    {
        switch (other.gameObject.name)
        {
            case Anatomy.heart:
                Info.text = factCollection.facts[0].TextA;
                bubbleBig.growBubble = true;
                broadCaster = "heart";
                break;

            case Anatomy.lungs:
                Info.text = factCollection.facts[1].TextA;
                bubbleBig.growBubble = true;
                broadCaster = "lungs";
                break;

            case Anatomy.spine:
                Info.text = factCollection.facts[2].TextA;
                bubbleBig.growBubble = true;
                broadCaster = "spine";
                break;

            default:
                broadCaster = "none";
                break;
        }
    }

    void OnTriggerExit(Collider other)
    {
        switch (other.gameObject.name)
        {
            case Anatomy.heart:
                Info.text = "";
                bubbleBig.growBubble = false;

                break;
            case Anatomy.lungs:
                Info.text = "";
                bubbleBig.growBubble = false;

                break;
            case Anatomy.spine:
                Info.text = "";
                bubbleBig.growBubble = false;

                break;

            default:
                break;
        }
    }
}