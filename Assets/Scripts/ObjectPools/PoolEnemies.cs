using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolEnemies
{
    private EnemyData m_Data;
    private bool m_AutoExpand;
    private Transform m_Conteiner;
    private Vector2 m_Position;

    public EnemyData Data => m_Data;
    public bool AutoExpand => m_AutoExpand;
    public Transform Conteiner => m_Conteiner;

    private List<EnemyBase> m_Pool;

    public PoolEnemies(EnemyData data, int count, bool expanding)
    {
        m_Data = data;
        m_AutoExpand = expanding;
        m_Conteiner = null;

        CreatePool(count);
    }

    public PoolEnemies(EnemyData data, int count, bool expanding, Transform conteiner)
    {
        m_Data = data;
        m_AutoExpand = expanding;
        m_Conteiner = conteiner;

        CreatePool(count);
    }

    private void CreatePool(int count)
    {
        m_Pool = new List<EnemyBase>();

        for (int i = 0; i < count; i++)
         CreateObject();
    }

    private EnemyBase CreateObject(bool isActiveByDefault = false)
    {
        EnemyView view = Object.Instantiate(m_Data.ViewPrefab, m_Conteiner);

        view.gameObject.SetActive(isActiveByDefault);

        EnemyBase enemy = new EnemyBase(m_Data);

        enemy.AttachView(view);
        enemy.View.CreateMoveAgent();

        m_Pool.Add(enemy);
        return enemy;
    }

    public bool HasFreeElement(out EnemyBase element)
    {
        foreach(EnemyBase mono in m_Pool)
        {
            if (!mono.View.gameObject.activeInHierarchy)
            {
                element = mono;
                return true;
            }
        }

        element = null;
        return false;
    }

    public EnemyBase GetFreeElement()
    {
        if (HasFreeElement(out EnemyBase element))
            return element;

        if (m_AutoExpand)
           return CreateObject(true);

        throw new System.Exception($"Has no free element in pool of tpe {typeof(EnemyBase)}");
    }
}
