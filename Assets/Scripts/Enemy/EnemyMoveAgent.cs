using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMoveAgent : IEnemyMoveAgent
{
    
    private NavMeshAgent m_Agent;

    public EnemyMoveAgent(NavMeshAgent agent, EnemyData data)
    {
        m_Agent = agent;
    }

    public void EnemyMoveUpdate()
    {
        m_Agent.SetDestination(Game.Player.Charater.View.gameObject.transform.position);
    }
}
