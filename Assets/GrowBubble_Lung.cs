using UnityEngine;
using System.Collections;


public class GrowBubble_Lung : MonoBehaviour
{
    public bool growBubble = false;
    float growNum = 0;
    BubbleBobber floatHeight;
    // Use this for initialization
    void Start()
    {

        floatHeight = GetComponent<BubbleBobber>();
    }

    // Per frame update
    void Update()
    {
        if (growBubble == true)
        {
            if (growNum <= 0.31)
            {
                transform.localScale = new Vector3(growNum, growNum, growNum);

                growNum = growNum + 0.1f;

                floatHeight.midpoint = floatHeight.midpoint + growNum / 2;

            }

        }
        else
        {
            transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            growNum = 0.5f;
            floatHeight.midpoint = .75f; // This tells where in space the bubble is floating (upwards)
        }
    }
}