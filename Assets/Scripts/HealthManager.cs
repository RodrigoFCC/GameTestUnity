using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{   
    public EnemyObject enemySRC;
    public PlayerObject playerSRC;

    public Image healthBar;

    private void OnEnable()
    {
        Actions.OnEnemyTouch += getHit;
    }

    private void OnDisable()
    {
        Actions.OnEnemyTouch -= getHit;
    
    }

    public void getHit(Enemy atackRef){
        playerSRC.health -= enemySRC.atack;
        healthBar.fillAmount = Mathf.Clamp(playerSRC.health / playerSRC.maxHealth, 0, 1);
    }
}
