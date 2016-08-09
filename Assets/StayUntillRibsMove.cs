using UnityEngine;
using System.Collections;

public class StayUntillRibsMove : MonoBehaviour
{
    Rigidbody rb;
    BoxCollider collide;

    // Use this for initialization
    void Start()
    {
        rb = GameObject.Find("Ribs").GetComponent<Rigidbody>();
        collide = gameObject.GetComponent<BoxCollider>();


    }

    // Update is called once per frame
    void Update()
    {

        if (rb.isKinematic == true)
        {
            collide.enabled = false;
        }
        if (rb.isKinematic == false)
        {
            collide.enabled = true;
        }
    }
}
