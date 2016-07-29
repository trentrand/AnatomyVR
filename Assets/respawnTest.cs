using UnityEngine;
using System.Collections;

public class respawnTest : MonoBehaviour {
Vector3 initialPosition;
	// Use this for initialization
	void Start () {
        StartCoroutine(resetPositionOnInterval());
        initialPosition = gameObject.transform.position;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    IEnumerator resetPositionOnInterval()
    {
        yield return new WaitForSeconds(Random.Range(5, 10));

        // Reset position, then wait another Random seconds
        transform.position = initialPosition;
        
        StartCoroutine(resetPositionOnInterval());
    }
}
