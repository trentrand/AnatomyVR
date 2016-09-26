﻿using UnityEngine;
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
    public Material brain;
    public Material none;
    public Material lung;

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

        switch (other.gameObject.name)
        {
            case Anatomy.heart:
                Info.text = factCollection.facts[0].TextA;
                bubbleBig.growBubble = true;
                screen.number = true;
                GameObject.Find("Animation Orb (1)").GetComponent<MeshRenderer>().material = blood2;
                GameObject.Find("Animation Orb").GetComponent<MeshRenderer>().material = none;
                broadCaster = "heart";
                break;
            case Anatomy.brain:
                Info.text = factCollection.facts[4].TextA;
                bubbleBig.growBubble = true;
                screen.number = true;
                GameObject.Find("Animation Orb (1)").GetComponent<MeshRenderer>().material = brain;
                GameObject.Find("Animation Orb").GetComponent<MeshRenderer>().material = none;
                broadCaster = "brain";
                break;

            case Anatomy.lungs:
                Info.text = factCollection.facts[1].TextA;
                bubbleBig.growBubble = true;
                screen.number = true;
                GameObject.Find("Animation Orb (1)").GetComponent<MeshRenderer>().material = lung;
                GameObject.Find("Animation Orb").GetComponent<MeshRenderer>().material = none;
                broadCaster = "lungs";
                break;

            case Anatomy.spine:
                Info.text = factCollection.facts[2].TextA;
                bubbleBig.growBubble = true;
                screen.number = true;
                broadCaster = "spine";
                break;

            case Anatomy.ribs:
                Info.text = factCollection.facts[3].TextA;
                screen.number = true; broadCaster = "none";
                break;
            case Anatomy.skull:
                Info.text = factCollection.facts[5].TextA;
                screen.number = true; broadCaster = "none";
                break;
            case Anatomy.collarbone:
                Info.text = factCollection.facts[4].TextB;
                screen.number = true; broadCaster = "none";
                break;
            case Anatomy.shoulderblade:
                Info.text = factCollection.facts[5].TextB;
                screen.number = true; broadCaster = "none";
                break;
            case Anatomy.ulna:
                Info.text = factCollection.facts[0].TextB;
                screen.number = true; broadCaster = "none";
                break;
            case Anatomy.radius:
                Info.text = factCollection.facts[0].TextC;
                screen.number = true; broadCaster = "none";
                break;
            case Anatomy.hip:
                Info.text = factCollection.facts[4].TextC;
                screen.number = true; broadCaster = "none";
                break;
            case Anatomy.hand:
                Info.text = factCollection.facts[6].TextA;
                screen.number = true; broadCaster = "none";
                break;
            case Anatomy.femur:
                Info.text = factCollection.facts[7].TextC;
                screen.number = true; broadCaster = "none";
                break;
            case Anatomy.fibula:
                Info.text = factCollection.facts[7].TextB;
                screen.number = true; broadCaster = "none";
                break;
            case Anatomy.tibia:
                Info.text = factCollection.facts[7].TextA;
                screen.number = true; broadCaster = "none";
                break;
            case Anatomy.foot:
                Info.text = factCollection.facts[2].TextC;
                screen.number = true; broadCaster = "none";
                break;
            case Anatomy.kneecap:
                Info.text = factCollection.facts[1].TextC;
                screen.number = true; broadCaster = "none";
                break;
            case Anatomy.humerus:
                Info.text = factCollection.facts[1].TextB;
                screen.number = true; broadCaster = "none";
                break;
            case Anatomy.trachea:
                Info.text = factCollection.facts[2].TextB; ;
                screen.number = true;broadCaster = "none";
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
                GameObject.Find("Animation Orb (1)").GetComponent<MeshRenderer>().material = none;
                GameObject.Find("Animation Orb").GetComponent<MeshRenderer>().material = none;
                screen.number = false;
                broadCaster = "none";
                break;
            case Anatomy.brain:
                Info.text = "";
                bubbleBig.growBubble = false;
                GameObject.Find("Animation Orb (1)").GetComponent<MeshRenderer>().material = none;
                GameObject.Find("Animation Orb").GetComponent<MeshRenderer>().material = none;
                screen.number = false;
                broadCaster = "none";
                break;
            case Anatomy.lungs:
                Info.text = "";
                bubbleBig.growBubble = false;
                GameObject.Find("Animation Orb (1)").GetComponent<MeshRenderer>().material = none;
                GameObject.Find("Animation Orb").GetComponent<MeshRenderer>().material = none;
                screen.number = false;
                broadCaster = "none";

                break;
            case Anatomy.spine:
                Info.text = "";
                bubbleBig.growBubble = false;
                GameObject.Find("Animation Orb (1)").GetComponent<MeshRenderer>().material = none;
                GameObject.Find("Animation Orb").GetComponent<MeshRenderer>().material = none;
                screen.number = false;
                broadCaster = "none";

                break;
            case Anatomy.ribs:
                Info.text = "";
                screen.number = false;
                break;
            case Anatomy.skull:
                Info.text = "";
                screen.number = false;
                break;
            case Anatomy.collarbone:
                Info.text = "";
                screen.number = false;
                break;
            case Anatomy.shoulderblade:
                Info.text = "";
                screen.number = false;
                break;
            case Anatomy.ulna:
                Info.text = "";
                screen.number = false;
                break;
            case Anatomy.radius:
                Info.text = "";
                screen.number = false;
                break;
            case Anatomy.hip:
                Info.text = "";
                screen.number = false;
                break;
            case Anatomy.hand:
                Info.text = "";
                screen.number = false;
                break;
            case Anatomy.foot:
                Info.text = "";
                screen.number = false;
                break;
            case Anatomy.humerus:
                Info.text = "";
                screen.number = false;
                break;
            case Anatomy.fibula:
                Info.text = "";
                screen.number = false;
                break;
            case Anatomy.tibia:
                Info.text = "";
                screen.number = false;
                break;
            case Anatomy.kneecap:
                Info.text = "";
                screen.number = false;
                break;
            case Anatomy.femur:
                Info.text = "";
                screen.number = false;
                break;
            case Anatomy.trachea:
                Info.text = "";
                screen.number = false;
                break;


            default:

                break;
        }
    }
}