using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovementAgent : ICharacterMoveAgent
{
    private CharacterController m_CharacterControl;

    public CharacterMovementAgent(CharacterController characterControl) => m_CharacterControl = characterControl;

    public void CharacterMoveUpdate(Vector3 derection) => m_CharacterControl.Move(derection);
}
