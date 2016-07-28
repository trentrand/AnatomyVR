using UnityEngine;
using System.Collections;

public class Bloodmovement2 : MonoBehaviour
{
    int ranRotateNum = Random.Range(100, 200);
    Vector3 initialPosition;
    // Use this for initialization
    void Start()
    {
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
        yield return new WaitForSeconds(1.1f);

        // Reset position, then wait another 1.1 seconds
        transform.position = initialPosition;
        StartCoroutine(resetPositionOnInterval());
    }


}