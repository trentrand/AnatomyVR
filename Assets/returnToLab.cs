using UnityEngine;
using System.Collections;
using NewtonVR;
using UnityEngine.SceneManagement;
using Valve.VR;

//using SteamVR;
public class returnToLab : MonoBehaviour
{
    public NVRHand controllerl;
    public NVRHand controllerr;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        //        if (controllerl.UseButtonPressed == true || controllerr.UseButtonPressed == true)
        //     {
        //
        //         SceneManager.LoadScene("Anatomy");
        //     }

        if (SteamVR_Controller.Input(3).GetPress(EVRButtonId.k_EButton_ApplicationMenu) || SteamVR_Controller.Input(4).GetPress(EVRButtonId.k_EButton_ApplicationMenu))
        {

            SceneManager.LoadScene("Anatomy");
        }
    }
}
