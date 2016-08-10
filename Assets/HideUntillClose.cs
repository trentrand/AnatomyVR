using UnityEngine;
using System.Collections;

public class HideUntillClose : MonoBehaviour
{
    GameObject child;
    Vector3 dis1;
    Vector3 dis2;
    float disTotal;
    // Use this for initialization
    void Start()
    {
        child = GameObject.Find("LABEL");
        child.SetActive(false);
        dis1 = child.transform.position;
        dis2 = Camera.main.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        dis1.z = child.transform.position.z;
        dis2.z = Camera.main.transform.position.z;
        disTotal = dis1.z - dis2.z;
        if (disTotal <= 25)
        {
            child.SetActive(true);
        }
        else
        {
            child.SetActive(false);
        }

    }
}
