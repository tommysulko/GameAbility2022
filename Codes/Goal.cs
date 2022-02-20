using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        BallController component = other.gameObject.GetComponent<BallController>();//creation of the object for the win of level
        if(component != null)//control of the hit
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);//when we hit the object, we are taken to the next level
        }
    }
}
