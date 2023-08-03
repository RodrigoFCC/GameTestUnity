using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "coinSettings", menuName = "Coin/New Coin")]
[System.Serializable]
public class CoinObject : ScriptableObject
{
    public int coins;
}
