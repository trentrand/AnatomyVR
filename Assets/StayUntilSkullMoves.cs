using UnityEngine;
using System.Collections;
using NewtonVR;

public class StayUntilSkullMoves : MonoBehaviour
{
    Rigidbody rb;
    BoxCollider collide;
    Vector3 iniPos;
    NVRInteractableItem nvritem;
   

    // Use this for initialization
    void Start()
    {
        iniPos = transform.position;
        rb = GameObject.Find("Skull").GetComponent<Rigidbody>();
        collide = gameObject.GetComponent<BoxCollider>();
        nvritem = GetComponent<NVRInteractableItem>();


    }

    // Update is called once per frame
    void Update()
    {

        if (rb.isKinematic == true && iniPos == transform.position)
        {
            collide.enabled = false; nvritem.enabled = false;
            Debug.Log("BrainCantMove");
        }
        else
        {
            collide.enabled = true; nvritem.enabled = true;
            Debug.Log("BrainCanMove");
        }
    }
}
