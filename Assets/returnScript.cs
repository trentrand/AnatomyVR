using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using NewtonVR;
public class returnScript : MonoBehaviour
{
    NVRInteractableItem grabScript;
    // Use this for initialization
    void Start()
    {
        grabScript = gameObject.GetComponent<NVRInteractableItem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (grabScript.AttachedHand != null)
        {
            SceneManager.LoadScene("Anatomy");
        }
    }

}
