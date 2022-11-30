using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Datas/CharacterData", fileName = "CharacterData")]
public class CharacterData : ScriptableObject
{
    public int StartHealth;
    public int StartDamade;
    public CharacterView ViewPrefab;
}
