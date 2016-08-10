using UnityEngine;
using System.Collections;

public class StayUntillRibsMove : MonoBehaviour
{
    Rigidbody rb;
    BoxCollider collide;
    Vector3 iniPos;

    // Use this for initialization
    void Start()
    {
        iniPos = transform.position;
        rb = GameObject.Find("Ribs").GetComponent<Rigidbody>();
        collide = gameObject.GetComponent<BoxCollider>();


    }

    // Update is called once per frame
    void Update()
    {

        if (rb.isKinematic == true && iniPos == transform.position)
        {
            collide.enabled = false;
        }
        else
        {
            collide.enabled = true;
        }
    }
}
