using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMoveController : IController
{
    private ICharacterMoveAgent m_MoveAgent;

    public void OnStart()
    {
        m_MoveAgent = Game.Player.Charater.View.MoveAgent;
    }

    public void OnStop(){}

    public void OnUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontal, 0, vertical);

        Vector3 dir = Input.mousePosition - Game.Player.cam.WorldToScreenPoint(Game.Player.Charater.View.transform.position);
        float angle = Mathf.Atan2(dir.x, dir.y) * Mathf.Rad2Deg;

        m_MoveAgent.CharacterMoveUpdate(direction, angle);
    }
}
