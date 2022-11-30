using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Datas/CharacterChoiseData", fileName = "CharacterChoiseData")]
public class CharacterChoiseData : ScriptableObject
{
    public List<CharacterData> Characters = new();
}
