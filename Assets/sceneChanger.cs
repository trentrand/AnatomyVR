using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using NewtonVR;

public class sceneChanger : MonoBehaviour
{
    public InfoStation item;
    NVRInteractableItem grabScript;


    // Use this for initialization
    void Start()
    {
        item = GameObject.Find("Table").GetComponent<InfoStation>();
        grabScript = gameObject.GetComponent<NVRInteractableItem>();
    }

    void Update()
    {
        if (grabScript.AttachedHand != null)
        {
            if (item.broadCaster == "none")
            {
                //Nothing Happens :)

            }

            if (item.broadCaster == "heart")
            {
                SceneManager.LoadScene("BloodSceen");
            }
            if (item.broadCaster == "lungs")
            {
                SceneManager.LoadScene("lungScene");
            }
            if (item.broadCaster == "spine")
            {
                // SceneManager.LoadScene("NerveScene");
            }
            if (item.broadCaster == "brain")
            {
                SceneManager.LoadScene("brainScene");

            }

        }



    }
}