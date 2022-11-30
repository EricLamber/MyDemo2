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
        Vector3 derection = new Vector3(horizontal, 0, vertical);

        m_MoveAgent.CharacterMoveUpdate(derection);
    }
}
