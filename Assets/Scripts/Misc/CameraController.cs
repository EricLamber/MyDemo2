using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : IController
{
    public void OnStart(){}

    public void OnStop(){}

    public void OnUpdate()
    {
        Vector3 position = new Vector3(
            Game.Player.Charater.View.transform.position.x,
            Game.Player.cam.transform.position.y,
            Game.Player.Charater.View.transform.position.z - 10);

        Game.Player.cam.transform.position = position;
    }
}
