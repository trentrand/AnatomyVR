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
        transform.position =(currentPos);
	}
}
