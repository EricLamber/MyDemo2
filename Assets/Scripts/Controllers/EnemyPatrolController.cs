using UnityEngine;

public class EnemyPatrolController : IController
{
    float timer;

    public void OnStart()
    {
        timer = 0;
    }

    public void OnStop() { }

    public void OnUpdate()
    {
        if (timer > 5)
        {
            NewDestenetion();
            timer = 0;
        }

        timer += Time.deltaTime;
    }

    private void NewDestenetion()
    {
        foreach (Enemy enemy in Game.Player.Enemies)
        {
            Vector3 destenetion = enemy.View.Agent.transform.position + new Vector3(Random.Range(-5, 5), 0, Random.Range(-5, 5));
            enemy.View.Agent.SetDestination(destenetion);
        }
    }
}
