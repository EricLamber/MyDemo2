using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovementAgent : ICharacterMoveAgent
{
    private CharacterController m_CharacterControl;
    private float m_Speed;

    public CharacterMovementAgent(CharacterController characterControl, float speed)
    {
        m_CharacterControl = characterControl;
        m_Speed = speed;
    }

    public void CharacterMoveUpdate(Vector3 direction, float lookAt) 
    {
        m_CharacterControl.transform.rotation = Quaternion.AngleAxis(lookAt, Vector3.up);

        m_CharacterControl.SimpleMove(direction * m_Speed); 
    }
}
