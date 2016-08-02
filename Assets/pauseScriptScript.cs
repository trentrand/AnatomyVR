using UnityEngine;
using System.Collections;
using NewtonVR;

public class pauseScriptScript : MonoBehaviour {

    NVRInteractableItem grabScript;
    BloodMovement2fixed bloodMovementScript;

	// Use this for initialization
	void Start () {
        grabScript = gameObject.GetComponent<NVRInteractableItem>();
        bloodMovementScript = gameObject.GetComponent<BloodMovement2fixed>();
	}
	
	// Update is called once per frame
	void Update () {
	    if (grabScript.AttachedHand != null)
        {
            bloodMovementScript.enabled = false;
        }
	}
}
