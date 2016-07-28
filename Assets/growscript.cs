using UnityEngine;
using System.Collections;

public class growscript : MonoBehaviour {
    public bool number = false;
    float growNum = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (number == true)
        {
            if (growNum <= 1.1)
            {
                transform.localScale = new Vector3(1, growNum, 0.0001f);
           
                growNum = growNum + 0.1f;
                
            }
            
        }else
            {
                transform.localScale = new Vector3(0,0,0);
            growNum = 0;
            
            }
	}

    
}


