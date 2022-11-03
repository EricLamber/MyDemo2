using UnityEngine;

public class EnemyView : MonoBehaviour
{
    private Enemy m_Enemy;

    public Enemy Enemy => m_Enemy;


    internal void AttachData(Enemy enemy)
    {
        m_Enemy = enemy;
    }

    internal void Die()
    {
        Destroy(gameObject);
    }
}