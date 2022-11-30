using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSpawnController : IController
{
    public void OnStart()
    {
        CharacterView view = Object.Instantiate(Game.DataRoot.Character.ViewPrefab, Vector3.zero, Quaternion.identity);

        CharacterBase character = new CharacterBase(Game.DataRoot.Character);

        character.AttachView(view);
        character.View.CreateCharacterControl();
        character.View.CreateMoveAgent();

        Game.Player.AddCharacter(character);
    }

    public void OnStop(){}

    public void OnUpdate(){}
}
