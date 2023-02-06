using UnityEngine;

public interface ICharacterMoveAgent
{
    void CharacterMoveUpdate(Vector3 direction, float lookAt);
}
