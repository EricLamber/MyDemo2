using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStarter : MonoBehaviour
{
    [SerializeField] private DataRoot m_DataRoot;
    [SerializeField] private CharacterChoiseData m_CharacterChoise;
    [SerializeField] private List<Button> m_CharacterCoiseButtons = new();

    private void Awake()
    {
        m_CharacterCoiseButtons[0].onClick.AddListener(CubeChoise);
    }

    private void CubeChoise()
    {
        Game.SetDataRoot(m_DataRoot, m_CharacterChoise.Characters[0]);
        Game.StartLevel(m_DataRoot.Levels[0]);
    }
}
