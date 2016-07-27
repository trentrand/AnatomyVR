using UnityEngine;
using System.Collections;

public class Bloodmovement : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
        transform.Rotate(Vector3.one * Time.deltaTime*Random.Range(100, 500));
        
    }
}
