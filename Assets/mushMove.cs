using UnityEngine;
using System.Collections;

public class mushMove : MonoBehaviour
{
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
        transform.Translate(Vector3.back * Time.deltaTime * 50);
    }
    IEnumerator resetPositionOnInterval()
    {
        yield return new WaitForSeconds(Random.Range(14, 14));

        // Reset position, then wait another Random seconds
        transform.position = initialPosition;
        StartCoroutine(test());
        StartCoroutine(resetPositionOnInterval());
    }
    IEnumerator test()
    {
        yield return new WaitForSeconds(1f);
    }

}

