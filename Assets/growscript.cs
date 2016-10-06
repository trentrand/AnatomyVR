using UnityEngine;
using System.Collections;

public class growscript : MonoBehaviour
{
    public bool number = false;
    float growNum = 0;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (number == true)
        {
            if (growNum <= 1.331979)
            {
                transform.localScale = new Vector3(1.341323f, growNum, 0.0120887f);

                growNum = growNum + 0.1f;

            }

        }
        else
        {
            transform.localScale = new Vector3(0, 0, 0);
            growNum = 0;

        }
    }


}


