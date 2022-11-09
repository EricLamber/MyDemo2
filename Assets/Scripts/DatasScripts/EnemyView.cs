using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class EnemyView : MonoBehaviour
{
    private Enemy m_Enemy;

    [SerializeField] private NavMeshAgent m_Agent;

    public Enemy Enemy => m_Enemy;
    public NavMeshAgent Agent => m_Agent;

    public void AttachData(Enemy enemy)
    {
        m_Enemy = enemy;
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}