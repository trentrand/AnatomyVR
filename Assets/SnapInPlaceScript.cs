using UnityEngine;
using System.Collections;
using NewtonVR;

public class SnapInPlaceScript : MonoBehaviour
{
    // Store initial transform values
    Vector3 initialPosition;
    Quaternion initialRotation;

    // Reference the Rigidbody
    Rigidbody rb;

    // Reference the NVRInteractableItem script
    NVRInteractableItem grabScript;

    // Reference ghost placeholder GameObject
    public GameObject ghostPlaceholder;

    // Use this for initialization
    void Start()
    {
        // Retrieve reference to components
        rb = GetComponent<Rigidbody>();
        grabScript = GetComponent<NVRInteractableItem>();

        // Store initial transform values
        initialPosition = transform.position;
        initialRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        // If the <gameObject> is grabbed
        if (grabScript.AttachedHand != null)
        {
            if (ghostPlaceholder != null)
                // Show placeholder ghost outline
                ghostPlaceholder.SetActive(true);
        }
        // Else if <gameObject> is not grabbed and position is close to original position
        else if (Vector3.Distance(initialPosition, transform.position) < 0.2)
        {
            if (ghostPlaceholder != null)
                // Disable placeholder ghost outline
                ghostPlaceholder.SetActive(false);

            // Snap back to initial position
            rb.isKinematic = true;
            transform.position = initialPosition;
            transform.rotation = initialRotation;
        }
    }
}
