﻿using UnityEngine;
using System.Collections;
using NewtonVR;

public class PauseBob : MonoBehaviour
{

    NVRInteractableItem grabScript;
    public BubbleBobber bobscript;
    Vector3 initialPosition;
    Quaternion iniRot;


    // Use this for initialization
    void Start()
    {
        grabScript = gameObject.GetComponent<NVRInteractableItem>();
        bobscript = gameObject.GetComponent<BubbleBobber>();
        initialPosition = gameObject.transform.position;
        iniRot = gameObject.transform.rotation;
        bobscript.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (grabScript.AttachedHand != null)
        {
            bobscript.enabled = false;
        }
        else
        {
            bobscript.enabled = true;
            transform.position = initialPosition;
            transform.rotation = iniRot;

        }
    }
}
