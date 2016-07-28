using UnityEngine;
using System.Collections;
using System;

public class InfoStation : MonoBehaviour
{
    TextMesh Info;

    void Start()
    {
        Info = GameObject.Find("Info").GetComponent<TextMesh>();
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
                    Info.text = "Chicken, pig, and beef hearts are all eaten across the globe. your heart is in your chest and is protected by your rib cage. Blood is the fluid that provides the body with oxygen and nutrients. The heart is very important, it is the organ that pumps blood throughout the body. The study of the heart is cardiology. Blood that goes towards the heart is carried through tubes called veins. Blood that leaves the heart that goes to the other organs, are carried through tubes called arteries.";
                }
                break;
            case "Lungs":
                if (other.gameObject.tag == "Lungs")
                {
                    Info.text = "HELLO WORLD numero dos";
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