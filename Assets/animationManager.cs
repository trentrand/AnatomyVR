using UnityEngine;
using System.Collections;
using Valve.VR;

public class animationManager : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (SteamVR_Controller.Input(1).GetPress(EVRButtonId.k_EButton_ApplicationMenu) || SteamVR_Controller.Input(2).GetPress(EVRButtonId.k_EButton_ApplicationMenu))
        {
            Debug.Log("pushed");
        }

    }
}