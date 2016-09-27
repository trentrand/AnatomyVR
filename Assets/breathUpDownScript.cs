using UnityEngine;
using System.Collections;

public class breathUpDownScript : MonoBehaviour
{

    // Use this for initialization
    public int timer = 0;
    bool down = true;
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (timer == 0)
        {
            down = false;
        }
        if (timer == 160)
        {
            down = true;
        }
        if (down == false)
        {
            transform.Translate(Vector3.down * Time.deltaTime * 65);
            timer++;
        }
        if (down == true)
        {
            transform.Translate(Vector3.up * Time.deltaTime * 65);
            timer--;
        }
    }

}