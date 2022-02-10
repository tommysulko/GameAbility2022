using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public Image healthBar;
    public static float healthAmount = 100;
    public float threshold = -50;


    private void Update()
    {
        if (healthAmount <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
        }

        if (transform.position.y < threshold)
        {
            TakeDamage(20);
        }

        
        if (Input.GetKeyDown(KeyCode.E))
        {
            TakeDamage(20);
        }
        /*
        if (Input.GetKeyDown(KeyCode.T))
        {
            Healing(10);
        }*/
    }

    public void TakeDamage(float Damage)
    {
        healthAmount -= Damage;
        healthBar.fillAmount = healthAmount / 100;
    }
    /*
    public void Healing(float healPoints)
    {
        healthAmount += healPoints;
        healthAmount = Mathf.Clamp(healthAmount, 0, 100);

        healthBar.fillAmount = healthAmount / 100;
    }*/

}