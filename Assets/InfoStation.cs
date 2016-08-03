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
        bubbleBig = GameObject.Find("Sphere").GetComponent<GrowBubble>();

    }

    void OnTriggerEnter(Collider other)
    {
        // Output collided object's name
        Debug.Log(other.gameObject.name);

        switch (other.gameObject.name)
        {
            case Anatomy.heart:
                //Why are you assuming a male is reading the info?
                Info.text = factCollection.facts[1].TextA;
                bubbleBig.growBubble = true;
                broadCaster = "heart";
                break;

            case Anatomy.lungs:
                Info.text = factCollection.facts[1].TextA;
                bubbleBig.growBubble = true;
                broadCaster = "lungs";
                break;

            case Anatomy.spine:
                Info.text = "HELLO WORLD";
                bubbleBig.growBubble = true;
                broadCaster = "spine";
                break;

            default:
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