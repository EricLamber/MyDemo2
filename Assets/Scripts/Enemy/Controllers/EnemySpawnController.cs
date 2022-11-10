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

    public EnemySpawnController(SpawnEnemyData spawnEnemyData, float LevelHight, float LevelWeight)
    {
        m_SpawnEnemyData = spawnEnemyData;
        m_LevelHight = LevelHight;
        m_LevelWeight = LevelWeight;
    }

    public void OnStart()
    {
        for (int i = 0; i < m_SpawnEnemyData.Enemies.Count; i++)
        {
            EnemySpawn(m_SpawnEnemyData.Enemies[i]);
        }
    }

    public void OnStop() { }

    public void OnUpdate() { }

    private void EnemySpawn(EnemyData data)
    {
        EnemyView view = Object.Instantiate(data.ViewPrefab);

        var HalfOfLevelHight = m_LevelHight / 2;
        float xCord = Random.Range(-HalfOfLevelHight, HalfOfLevelHight);

        var HalfOfLevelWeight = m_LevelWeight / 2;
        float zCord = Random.Range(-HalfOfLevelWeight, HalfOfLevelWeight);

        view.transform.position = new Vector3(xCord, 0, zCord);

        EnemyBase enemy = new EnemyBase(data);

        enemy.AttachView(view);
        enemy.View.CreateMoveAgent();

        Game.Player.EnemySpawned(enemy);
    }
}
