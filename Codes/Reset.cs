using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    public float threshold = -50;
   // public AudioSource hitSound;

    // Update is called once per frame
    void Update()
    {
        
        if (transform.position.y < threshold)
        {
           // hitSound.Play();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }    
    }
}
