using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Datas/CharacterData", fileName = "CharacterData")]
public class CharacterData : ScriptableObject
{
    [SerializeField] private int m_BaseHealth;
    [SerializeField] private int m_BaseDamade;
    [SerializeField] private int m_Speed;
    [SerializeField] private CharacterView m_ViewPrefab;
    [SerializeField] private ProjectileView m_ProjectilePrefab;

    public int BaseHealth => m_BaseHealth;
    public int BaseDamade => m_BaseDamade;
    public int Speed => m_Speed;
    public CharacterView ViewPrefab => m_ViewPrefab;
    public ProjectileView ProjectilePrefab => m_ProjectilePrefab;
}
