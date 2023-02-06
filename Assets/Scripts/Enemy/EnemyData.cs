using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Datas/EnemyData", fileName = "EnemyData")]
public class EnemyData : ScriptableObject
{
    [SerializeField] private int m_StartHealth;
    [SerializeField] private float m_Speed;
    [SerializeField] private EnemyView m_ViewPrefab;
    [SerializeField] private int m_Damage;

    public int StartHealth => m_StartHealth;
    public float Speed => m_Speed;
    public EnemyView ViewPrefab => m_ViewPrefab;
    public int Damage => m_Damage;

    //public Something for Reward; May be int for Rewards Dictionary key...
}
