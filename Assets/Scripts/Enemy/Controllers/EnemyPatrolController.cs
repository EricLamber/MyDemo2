using UnityEngine;

public class EnemyPatrolController : IController
{
    public void OnStart() { }

    public void OnStop() { }

    public void OnUpdate()
    {
        foreach (EnemyBase enemy in Game.Player.Enemies)
        {
            enemy.View.MoveAgent.EnemyMoveUpdate();
        }
    }
}
