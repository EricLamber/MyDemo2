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
        agent.speed = m_Enemy.Data.Speed;
        m_MoveAgent = new EnemyMoveAgent(agent);
    }

    private void OnDisable() => Game.Player.EnemyDied(m_Enemy);

    public void Die() => gameObject.SetActive(false);
}