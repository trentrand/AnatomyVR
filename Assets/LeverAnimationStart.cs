using UnityEngine;
using System.Collections;

public class LeverAnimationStart : MonoBehaviour {
    public BoxCollider triggerCollider;
    public Animator handMover;
    // Use this for initialization
    void Start () {
        handMover = GameObject.Find("vr_controller_vive_1_5").GetComponent<Animator>();
        handMover.applyRootMotion = false;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "LeverHandle")
        {
            handMover.applyRootMotion = true;

        }
    }
}
