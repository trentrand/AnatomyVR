using UnityEngine;
using System.Collections;

public class breathUpDownScript : MonoBehaviour {
    Vector3 currentPos;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        currentPos = Vector3.up + currentPos;
        transform.position = (currentPos);
        if (transform.position.y >= 500)
        {
            currentPos = Vector3.down + currentPos;
            transform.position = (currentPos);
        }
        if (transform.position.y <= 0)
        {
            currentPos = Vector3.up + currentPos;
            transform.position = (currentPos);
        }
	}
}
