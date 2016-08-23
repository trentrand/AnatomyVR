using UnityEngine;
using System.Collections;
using NewtonVR;
using UnityEngine.SceneManagement;
using Valve.VR;

//using SteamVR;
public class turnOnOffScript : MonoBehaviour
{
    Vector3 initialPosition;
    public NVRHand controllerl;
    public NVRHand controllerr;
    public breathUpDownScript script;
    // Use this for initialization
    void Start()
    {
        initialPosition = gameObject.transform.position;
        script = GetComponent<breathUpDownScript>();
    }

    // Update is called once per frame
    void Update()
    {

        if (controllerl.UseButtonPressed == true || controllerr.UseButtonPressed == true)
        {

            script.enabled = true;

        }
        else
        {
            script.timer = 0;
            transform.position = initialPosition;
            script.enabled = false;
        }
    }
}