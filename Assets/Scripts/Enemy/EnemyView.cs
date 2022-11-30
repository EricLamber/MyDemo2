using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class EnemyView : MonoBehaviour
{
    private EnemyBase m_Enemy;

    private IEnemyMoveAgent m_MoveAgent;

    public EnemyBase Enemy => m_Enemy;
    public IEnemyMoveAgent MoveAgent => m_MoveAgent;

    public void AttachBase(EnemyBase enemy) => m_Enemy = enemy;

    public void CreateMoveAgent()
    {
        NavMeshAgent agent = this.GetComponent<NavMeshAgent>();
        m_MoveAgent = new EnemyMoveAgent(agent, m_Enemy.Data);
    }

    public void Die() => Destroy(gameObject);
}