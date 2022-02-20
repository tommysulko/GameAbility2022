using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ostacolo : MonoBehaviour
{
    public AudioSource hitSound;

    private void OnTriggerEnter(Collider other)
    {
        //hitSound.Play();
        BallController component = other.gameObject.GetComponent<BallController>(); //create a box around the object
        if (component != null)//control of the hit
        {
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);//when the box gets hit the level restar
        }      
    }
}
