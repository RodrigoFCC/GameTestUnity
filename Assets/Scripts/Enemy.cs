using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public EnemyObject enemySettings;
    public GameObject Player;

    public int atack;
    public int hp;
    public bool playerIsDamage;
    
    void Start()
    {
        atack = enemySettings.atack;
        hp = enemySettings.hp;
    }

    public void decreaseHpEnemy(){
        if (hp > 0) {
            hp--;
        }
        else{
            this.gameObject.SetActive(false);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if(!playerIsDamage){
                Actions.OnEnemyTouch(this);
                Animator anim = Player.GetComponent<Animator>();
                anim.SetTrigger("Damage");
                Debug.Log(anim);
                playerIsDamage = true;
                Invoke("TogglePlayerIsDamage", 1f);
            }
        }
    }

    public void TogglePlayerIsDamage(){
        playerIsDamage = false;
    }

}


//animation para tomar dano (mudar o material quando tomar dano)
// UI game over
// chegar hp 0 gamer over + restart ( restart / quit)