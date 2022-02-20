using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{

    public Rigidbody RB3D;//creation of the object whit rigidbody

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("a"))//when we push letter "a", the ball go to left
        {
            RB3D.AddForce(-10, 0, 0);// force to go left
            RB3D.AddForce(0, 0,0);
        }

        if (Input.GetKey("d"))//when we push letter "d", the ball go to right
        {
            RB3D.AddForce(10, 0, 0);// force to go right
            RB3D.AddForce(0, 0, 0);
        }
    }
}
