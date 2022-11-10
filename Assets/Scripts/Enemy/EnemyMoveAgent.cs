using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMoveAgent : IMoveAgent
{
    
    private NavMeshAgent m_Agent;

    private float m_TimeBetweenMove;
    private float m_PatrolRadius;
    private Vector3 m_StartPosition;

    private float m_LastMoveTime = 0f;

    public EnemyMoveAgent(NavMeshAgent agent, EnemyData data)
    {
        m_Agent = agent;
        m_StartPosition = agent.transform.position;
        m_TimeBetweenMove = data.RateOfPatrol;
        m_PatrolRadius = data.PatrolRadius;
    }

    public void MoveUpdate()
    {
        float passedTime = Time.time - m_LastMoveTime;
        
        if (passedTime < m_TimeBetweenMove)
            return;

        float radiusx = Random.Range(-m_PatrolRadius, m_PatrolRadius);
        float radiusy = Random.Range(-m_PatrolRadius, m_PatrolRadius);
        Vector3 destenetion = m_StartPosition + new Vector3(radiusx, 0, radiusy);
        m_Agent.SetDestination(destenetion);

        m_LastMoveTime = Time.time;
    }
}
