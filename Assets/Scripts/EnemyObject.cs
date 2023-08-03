using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "enemySettings", menuName = "Enemy/New Enemy")]
[System.Serializable]
public class EnemyObject : ScriptableObject
{
    public int atack;
    public int hp;
}
