using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{   
    public CoinObject coinSRC;
    public EnemyObject enemySRC;
    public PlayerObject playerSRC;
    public NextScene nextSceneSRC;
    public GameController gameController;

    public Text coinText;
    public Image healthBar;
    public bool isDead;

    private void OnEnable()
    {
        Actions.OnCoinTouch += AddCoin;
        Actions.OnEnemyTouch += GetHit;
    }

    private void OnDisable()
    {
        Actions.OnCoinTouch -= AddCoin;
        Actions.OnEnemyTouch -= GetHit;
    }

    void Start()
    {
        coinText.text = "Coins: " + coinSRC.coins.ToString();
    }

    void Update()
    {
        isOpen();
        healthBar.fillAmount = Mathf.Clamp(playerSRC.health / playerSRC.maxHealth, 0, 1);
    }

    public void AddCoin(Coin coinRef) {
        coinSRC.coins += 1;
        coinText.text = "Coins: " + coinSRC.coins.ToString();
    }

    public void GetHit(Enemy atackRef) {
        playerSRC.health -= enemySRC.atack;
        if (playerSRC.health <= 0 && !isDead){
            isDead = true;
            gameController.GameOver();
        }
    }

    public void isOpen() {
        if (coinSRC.coins >= 8){
            nextSceneSRC.gameObject.SetActive(true);
        }
        else 
        {
            nextSceneSRC.gameObject.SetActive(false);
        }
    }
}
