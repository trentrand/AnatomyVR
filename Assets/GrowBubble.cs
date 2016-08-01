using UnityEngine;
using System.Collections;


public class GrowBubble : MonoBehaviour {
    public bool trueOrFalse = false;
    float growNum = 0;
    BubbleBobber floatHeight;
    // Use this for initialization
    void Start()
    {

        floatHeight = GetComponent<BubbleBobber>();
    }

    // Update is called once per frame
    void Update()
    {
        if (trueOrFalse == true)
        {
            if (growNum <= 0.31)
            {
                transform.localScale = new Vector3(growNum, growNum, growNum);

                growNum = growNum + 0.1f;

                floatHeight.midpoint = floatHeight.midpoint + growNum/2;

            }

        }
        else
        {
            transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
            growNum = 0.1f;
            floatHeight.midpoint = 0.3f;
        }
    }


}


