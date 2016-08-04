using UnityEngine;
using System.Collections;
using NewtonVR;

public class BubbleBobber : MonoBehaviour
{

    private float timer = 0.0f;
    float bobbingSpeed = 0.08f;
    float bobbingAmount = 0.01f;
    public float midpoint = 0.3f;

    NVRInteractableItem grabScript;
    Vector3 initialPosition;
    Quaternion initialRotation;

    void Start()
    {
        grabScript = gameObject.GetComponent<NVRInteractableItem>();

        initialPosition = gameObject.transform.position;
        initialRotation = gameObject.transform.rotation;
    }

    void Update()
    {
        // If no hand is attached
        if (grabScript.AttachedHand == null)
        {
            // If no hand is attached, and its not at its initial position, then snap back to place
            if (gameObject.transform.position.x != initialPosition.x || gameObject.transform.position.z != initialPosition.z)
            {
                gameObject.transform.position = initialPosition;
                gameObject.transform.rotation = initialRotation;
            }

            float waveslice = 0.0f;

            Vector3 cSharpConversion = transform.localPosition;

            waveslice = Mathf.Sin(timer);
            timer = timer + bobbingSpeed;
            if (timer > Mathf.PI * 2)
            {
                timer = timer - (Mathf.PI * 2);
            }

            if (waveslice != 0)
            {
                float translateChange = waveslice * bobbingAmount;
                float totalAxes = Mathf.Clamp(1, 0.0f, 1.0f);
                translateChange = totalAxes * translateChange;
                cSharpConversion.y = midpoint + translateChange;
            }
            else
            {
                cSharpConversion.y = midpoint;
            }

            transform.localPosition = cSharpConversion;
        }
    }
}