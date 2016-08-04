using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChanger : MonoBehaviour
{
    public InfoStation item;

    // Use this for initialization
    void Start()
    {
        item = GameObject.Find("Table").GetComponent<InfoStation>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "camera")
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
                // SceneManager.LoadScene("LungScene");
            }
            if (item.broadCaster == "spine")
            {
                // SceneManager.LoadScene("NerveScene");
            }

        }
    }
}