using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterView : MonoBehaviour
{
    private CharacterBase m_Character;
    private ICharacterMoveAgent m_MoveAgent;
    private CharacterController m_CharacterControl;
    
    public CharacterBase Character => m_Character;
    public ICharacterMoveAgent MoveAgent => m_MoveAgent;
    public CharacterController CharacterControl => m_CharacterControl;

    public void AttachBase(CharacterBase character) => m_Character = character;
    public void CreateCharacterControl() => m_CharacterControl = GetComponent<CharacterController>();
    public void CreateMoveAgent() => m_MoveAgent = new CharacterMovementAgent(m_CharacterControl);

    public void Die() => Destroy(gameObject);
}
