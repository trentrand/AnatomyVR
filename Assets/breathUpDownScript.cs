using UnityEngine;
using System.Collections;

public class breathUpDownScript : MonoBehaviour
{
    Vector3 initialPosition;
    // Use this for initialization
    int timer = 0;
    bool down = false;
    void Start()
    {

        initialPosition = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer == 0)
        {
            down = false;
        }
        if (timer == 200)
        {
            down = true;
        }
        if (down == false)
        {
            transform.Translate(Vector3.up * Time.deltaTime * 65);
            timer++;
        }
        if (down == true)
        {
            transform.Translate(Vector3.down * Time.deltaTime * 65);
            timer--;
        }
    }

}