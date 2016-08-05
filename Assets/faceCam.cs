using UnityEngine;
using System.Collections;

public class faceCam : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Face the camera directly.
        transform.LookAt(Camera.main.transform.position);

        // Rotate so the visible side faces the camera.
        transform.Rotate(0, 180, 0);
    }
}
