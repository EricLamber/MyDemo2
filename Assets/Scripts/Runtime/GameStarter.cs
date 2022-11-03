using UnityEngine;

public class GameStarter : MonoBehaviour
{
    [SerializeField] private DataRoot m_DataRoot;

    private void Awake()
    {
        Game.SetDataRoot(m_DataRoot);
    }

    //for start button or something like that idk
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Game.StartLevel(m_DataRoot.Levels[0]);
        }
    }
}
