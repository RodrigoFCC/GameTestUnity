using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerObject playerSettings;

    public float health;
    public float maxHealth;

    
    void Start()
    {
        playerSettings.health = 5;
        health = playerSettings.health;
        maxHealth = playerSettings.maxHealth;
    }

    void Update()
    {
        if(health <= 0)
        {
            this.gameObject.SetActive(false);
        }
    }

}
