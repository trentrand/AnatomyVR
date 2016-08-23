using UnityEngine;
using System.Collections;

public class goToSpotPlate : MonoBehaviour
{
    public GameObject SpotPlate;
    public float x;
    public float y;
    public float z;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = SpotPlate.transform.position + new Vector3(x, y, z);
        //transform.rotation = SpotPlate.transform.rotation;
    }
}
