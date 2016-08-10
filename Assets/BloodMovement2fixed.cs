using UnityEngine;
using System.Collections;
using NewtonVR;

public class BloodMovement2fixed : MonoBehaviour
{

    int ranRotateNum = Random.Range(100, 200);
    // Vector3 initialPosition;
    NVRInteractableItem grabScript;
    // Use this for initialization
    void Start()
    {
        //   StartCoroutine(test());
        //   StartCoroutine(resetPositionOnInterval());
        //  initialPosition = gameObject.transform.position;
        grabScript = GetComponent<NVRInteractableItem>();
    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(Vector3.one * Time.deltaTime * 100);




    }
    // IEnumerator resetPositionOnInterval()
    //  {
    //       yield return new WaitForSeconds(Random.Range(15,30));
    //
    //        // Reset position, then wait another Random seconds
    //        transform.position = initialPosition;
    //        StartCoroutine(test());
    //       StartCoroutine(resetPositionOnInterval());
    //   }
    //   IEnumerator test()
    //   {
    //      yield return new WaitForSeconds(1f);
    // }


}