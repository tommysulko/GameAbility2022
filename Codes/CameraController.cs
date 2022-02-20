using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject target;
    public float xOffset, yOffset, zOfset;

    // Update is called once per frame
    void Update()
    {

        transform.position = target.transform.position + new Vector3(xOffset, yOffset, zOfset);//position of the camera
        transform.LookAt(target.transform.position);//the camera is fixed on the ball
    }
}
