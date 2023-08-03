using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "playerSettings", menuName = "Player/New PLayer")]
[System.Serializable]
public class PlayerObject : ScriptableObject
{
    public float health;
    public float maxHealth;
}
