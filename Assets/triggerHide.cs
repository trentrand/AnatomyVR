using UnityEngine;
using System.Collections;
using NewtonVR;
public class triggerHide : MonoBehaviour
{
    public NVRHand trigger;
    public GameObject self;
    // Use this for initialization
    void Start()
    {
        self.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (trigger.UseButtonPressed == true)
        {
            self.SetActive(false);
        }
    }
}
