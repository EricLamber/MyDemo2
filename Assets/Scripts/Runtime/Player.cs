using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
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
}
