using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolMono<T> where T : MonoBehaviour
{
    [SerializeField] private T m_Prefab;
    [SerializeField] private bool m_AutoExpand;
    [SerializeField] private Transform m_Conteiner;

    public T Prefab => m_Prefab;
    public bool AutoExpand => m_AutoExpand;
    public Transform Conteiner => m_Conteiner;

    private List<T> m_Pool;

    public PoolMono(T prefab, int count)
    {
        m_Prefab = prefab;
        m_Conteiner = null;

        CreatePool(count);
    }

    public PoolMono(T prefab, int count, Transform conteiner)
    {
        m_Prefab = prefab;
        m_Conteiner = conteiner;

        CreatePool(count);
    }

    private void CreatePool(int count)
    {
        m_Pool = new List<T>();
        for (int i = 0; i < count; i++)
         CreateObject();
    }

    private T CreateObject(bool isActiveByDefault = false)
    {
        T createdObject = Object.Instantiate(m_Prefab, m_Conteiner);
        createdObject.gameObject.SetActive(isActiveByDefault);
        m_Pool.Add(createdObject);
        return createdObject;
    }

    public bool HasFreeElement(out T element)
    {
        foreach(T mono in m_Pool)
        {
            if (!mono.gameObject.activeInHierarchy)
            {
                element = mono;
                return true;
            }
        }

        element = null;
        return false;
    }

    public T GetFreeElement()
    {
        if (HasFreeElement(out T element))
            return element;

        if (m_AutoExpand)
           return CreateObject(true);

        throw new System.Exception($"Has no free element in pool of tpe {typeof(T)}");
    }
}
