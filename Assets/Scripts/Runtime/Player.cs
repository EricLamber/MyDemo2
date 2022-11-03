using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    private List<Enemy> m_Enemies = new List<Enemy>();
    public IReadOnlyList<Enemy> Enemies => m_Enemies;

    public void EnemySpawned(Enemy enemy)
    {
        m_Enemies.Add(enemy);
    }

    public void EnemyDied(Enemy enemy)
    {
        m_Enemies.Remove(enemy);
    }
}
