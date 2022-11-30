using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    #region Enemyies

    private List<EnemyBase> m_Enemies = new List<EnemyBase>();
    public IReadOnlyList<EnemyBase> Enemies => m_Enemies;

    public void EnemySpawned(EnemyBase enemy)
    {
        m_Enemies.Add(enemy);
    }

    public void EnemyDied(EnemyBase enemy)
    {
        m_Enemies.Remove(enemy);
    }

    #endregion

    #region Character

    private CharacterBase m_Charater;

    public CharacterBase Charater => m_Charater;

    private bool m_IsCharacterExist = false;
    public bool IsCharacterExist => m_IsCharacterExist;


    public void AddCharacter(CharacterBase Charater)
    {
        if (m_IsCharacterExist)
            return;

        m_Charater = Charater;
        m_IsCharacterExist = true;
    }

    public void RemoveCharacter(CharacterBase Charater)
    {
        if (!m_IsCharacterExist)
            return;

        m_Charater = null;
        m_IsCharacterExist = false;
    }

    #endregion
}
