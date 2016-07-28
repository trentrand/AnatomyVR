using UnityEngine;
using System.Collections;

public class BloodMovement2fixed : MonoBehaviour
{

    int ranRotateNum = Random.Range(100, 200);
    Vector3 initialPosition;
    // Use this for initialization
    void Start()
    {
        StartCoroutine(test());
        StartCoroutine(resetPositionOnInterval());
        initialPosition = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(Vector3.one * Time.deltaTime * 100);


    }
    IEnumerator resetPositionOnInterval()
    {
        yield return new WaitForSeconds(2.5f);

        // Reset position, then wait another 3.5 seconds
        transform.position = initialPosition;
        StartCoroutine(test());
        StartCoroutine(resetPositionOnInterval());
    }
    IEnumerator test()
    {
        yield return new WaitForSeconds(1f);
    }


}