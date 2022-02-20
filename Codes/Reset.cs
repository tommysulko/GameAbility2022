using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    public float threshold = -50;//our choice of size

    // Update is called once per frame
    void Update()
    {
        
        if (transform.position.y < threshold)//control of position
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);//if the position of the ball is < -50, the level restart
        }    
    }
}
