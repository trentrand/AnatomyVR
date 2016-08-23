using UnityEngine;
using System.Collections;

public class airMovement : MonoBehaviour
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
        transform.Translate(Vector3.down * Time.deltaTime * 30);
    }
    IEnumerator resetPositionOnInterval()
    {
        yield return new WaitForSeconds(Random.Range(5, 5));

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