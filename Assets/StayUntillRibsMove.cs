using UnityEngine;
using System.Collections;
using NewtonVR;

public class StayUntillRibsMove : MonoBehaviour
{
    Rigidbody rb;
    BoxCollider collide;
    Vector3 iniPos;
    NVRInteractableItem nvritem;
    Rigidbody selfRb;


    // Use this for initialization
    void Start()
    {
        iniPos = transform.position;
        rb = GameObject.Find("Ribs").GetComponent<Rigidbody>();
        collide = gameObject.GetComponent<BoxCollider>();
        nvritem = GetComponent<NVRInteractableItem>();
        selfRb = GetComponent<Rigidbody>();


    }

    // Update is called once per frame
    void Update()
    {

        if (rb.isKinematic == true && iniPos == transform.position)
        {
            collide.enabled = false; nvritem.enabled = false; selfRb.constraints = RigidbodyConstraints.FreezeAll;
            Debug.Log("BrainCantMove");
        }
        else
        {
            collide.enabled = true; nvritem.enabled = true; selfRb.constraints = RigidbodyConstraints.None;
            Debug.Log("BrainCanMove");
        }
    }
}
