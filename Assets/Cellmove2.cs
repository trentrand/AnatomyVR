using UnityEngine;
using System.Collections;

public class Cellmove2 : MonoBehaviour
{

    bool ready = false;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(test());
    }

    // Update is called once per frame
    void Update()
    {
        if(ready == true) {
            transform.Translate(Vector3.back * Time.deltaTime * 15);
        }
    }

    IEnumerator test()
    {
        yield return new WaitForSeconds(1f);
        ready = true;
    }

}