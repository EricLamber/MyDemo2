using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Datas/EnemyData", fileName = "EnemyData")]
public class EnemyData : ScriptableObject
{
    public int StartHealth;
    public float RateOfPatrol;
    public float PatrolRadius;
    public EnemyView ViewPrefab;

    public int Damage;
    //public Something for Reward; May be int for Rewards Dictionary key...
}
