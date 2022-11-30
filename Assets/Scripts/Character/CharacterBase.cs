using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBase
{
    private CharacterView m_View;
    private CharacterData m_Data;
    private int m_Health;

    public CharacterView View => m_View;
    public CharacterData Data => m_Data;
    public int Health => m_Health;

    public bool IsDead => m_Health <= 0;

    public event Action<int> OnCharacterHealthChanged;

    public CharacterBase(CharacterData data)
    {
        m_Data = data;
        m_Health = data.StartHealth;
    }

    public void AttachView(CharacterView view)
    {
        m_View = view;
        m_View.AttachBase(this);
    }

    public void GetDamage(int damage)
    {
        if (IsDead)
            return;

        m_Health -= damage;

        if (m_Health < 0)
            m_Health = 0;

        OnCharacterHealthChanged?.Invoke(m_Health);
    }

    public void Die() => View.Die();
}
