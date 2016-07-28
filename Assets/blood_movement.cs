using UnityEngine;
using System.Collections;


public class Bloodmovement : MonoBehaviour
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
        yield return new WaitForSeconds(2f);

        // Reset position, then wait another 2 seconds
        transform.position = initialPosition;

        StartCoroutine(resetPositionOnInterval());
    }

    public class blood_movement : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

    }
}
