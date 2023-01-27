using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Datas/SpawnEnemyData", fileName = "SpawnEnemyData")]
public class SpawnEnemyData : ScriptableObject
{
    public int NumberOfEnemiesOnField;
    public List<EnemyData> Enemies;
}