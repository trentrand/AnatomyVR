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
    GameObject image;
    public Material blood2;
    public Material none;
    growscript screen;

    void Start()
    {
        Info = GameObject.Find("Info").GetComponent<TextMesh>();
        factCollection = FactContainer.Load(xmlPath);
        triggerCollider = GetComponent<BoxCollider>();
        bubbleBig = GameObject.Find("Animation Orb").GetComponent<GrowBubble>();
        screen = GameObject.Find("HoloScreen (5)").GetComponent<growscript>();


    }

    void OnTriggerEnter(Collider other)
    {
        screen.number = true;
        switch (other.gameObject.name)
        {
            case Anatomy.heart:
                Info.text = factCollection.facts[0].TextA;
                bubbleBig.growBubble = true;

                GameObject.Find("Animation Orb (1)").GetComponent<MeshRenderer>().material = blood2;
                GameObject.Find("Animation Orb").GetComponent<MeshRenderer>().material = none;
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
        screen.number = false;
        switch (other.gameObject.name)
        {

            case Anatomy.heart:
                Info.text = "";
                bubbleBig.growBubble = false;
                GameObject.Find("Animation Orb (1)").GetComponent<MeshRenderer>().material = none;
                GameObject.Find("Animation Orb").GetComponent<MeshRenderer>().material = none;

                break;
            case Anatomy.lungs:
                Info.text = "";
                bubbleBig.growBubble = false;
                GameObject.Find("Animation Orb (1)").GetComponent<MeshRenderer>().material = none;
                GameObject.Find("Animation Orb").GetComponent<MeshRenderer>().material = none;
                break;
            case Anatomy.spine:
                Info.text = "";
                bubbleBig.growBubble = false;
                GameObject.Find("Animation Orb (1)").GetComponent<MeshRenderer>().material = none;
                GameObject.Find("Animation Orb").GetComponent<MeshRenderer>().material = none;
                break;

            default:
                break;
        }
    }
}