using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;
using Random = UnityEngine.Random;

public class EnemySpawnController : IController
{
    private SpawnEnemyData m_SpawnEnemyData;

    private float m_LevelHight;
    private float m_LevelWeight;

    private List<PoolEnemies> pools = new List<PoolEnemies>();

    public EnemySpawnController(SpawnEnemyData spawnEnemyData, float LevelHight, float LevelWeight)
    {
        m_SpawnEnemyData = spawnEnemyData;
        m_LevelHight = LevelHight;
        m_LevelWeight = LevelWeight;
    }

    public void OnStart()
    {
        for (int i = 0; i < m_SpawnEnemyData.Enemies.Count; i++)
            pools.Add(new PoolEnemies(m_SpawnEnemyData.Enemies[i], 4, true));
    }

    public void OnStop() { }

    public void OnUpdate() 
    {
        int defferense = m_SpawnEnemyData.NumberOfEnemiesOnField - Game.Player.Enemies.Count;

        if (defferense == 0)
            return;

        int maxNumOfEnemies = pools.Count;

        for (int i = 0; i < defferense; i++)
        {
            EnemyBase enemy = pools[Random.Range(0, maxNumOfEnemies)].GetFreeElement();
            EnemySpawn(enemy);
        }
    }

    private void EnemySpawn(EnemyBase enemy)
    {
        float HalfOfLevelHight = m_LevelHight * 0.5f;
        float xCord = Random.Range(-HalfOfLevelHight, HalfOfLevelHight);

        float HalfOfLevelWeight = m_LevelWeight * 0.5f;
        float zCord = Random.Range(-HalfOfLevelWeight, HalfOfLevelWeight);

        enemy.View.transform.position = new Vector3(xCord, 0, zCord);
        enemy.View.gameObject.SetActive(true);
        Game.Player.EnemySpawned(enemy);
    }
}
