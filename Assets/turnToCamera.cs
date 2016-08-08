using UnityEngine;
using System.Collections;

public class turnToCamera : MonoBehaviour
{
    public GameObject camera;
    Quaternion inirot;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // Face the camera directly.
        transform.LookAt(camera.transform.position);


        // Rotate so the visible side faces the camera.
        //transform.Rotate(0, 90, 0);

    }
}

