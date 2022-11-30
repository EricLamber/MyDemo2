using System;

public class EnemyBase
{
    private EnemyView m_View;
    private EnemyData m_Data;
    private int m_Health;

    public EnemyView View => m_View;
    public EnemyData Data => m_Data;
    public int Health => m_Health;

    public bool IsDead => m_Health <= 0;

    public event Action<int> OnEnemyHealthChanged;

    public EnemyBase(EnemyData data)
    {
        m_Data = data;
        m_Health = data.StartHealth;
    }

    public void AttachView(EnemyView view)
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

        OnEnemyHealthChanged?.Invoke(m_Health);
    }

    public void Die() => View.Die();
}
