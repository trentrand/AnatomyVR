using UnityEngine;
using System.Collections;
using NewtonVR;

public class SnapInPlaceScript : MonoBehaviour {
    Vector3 initialPosition;
    Quaternion iniRot;
    public Rigidbody rb;
    public NVRInteractableItem grabScript;
    public bool grabbed = false;

    // Use this for initialization
    void Start () {
	rb = GetComponent<Rigidbody>();
    initialPosition = transform.position;
    grabScript = GetComponent<NVRInteractableItem>();
    iniRot = transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
	    
        if (grabScript.AttachedHand == null && Vector3.Distance(initialPosition, transform.position) < 0.2)
        {
            rb.isKinematic = true;
            transform.position = initialPosition;
            transform.rotation = iniRot;
        }

	}
}
