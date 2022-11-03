using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(menuName = "Datas/LevelData", fileName = "LevelData")]
public class LevelData : ScriptableObject
{
    public SceneAsset SceneAsset;
    public SpawnEnemyData SpawnEnemyData;
}
