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
        BallController component = other.gameObject.GetComponent<BallController>();
        if (component != null)
        {
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }      
    }
}
