using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LeverToMainScene : MonoBehaviour
{
    public BoxCollider triggerCollider;

    // Use this for initialization
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "LeverHandle")
        {
            SceneManager.LoadScene("Anatomy");
        }
    }
}
