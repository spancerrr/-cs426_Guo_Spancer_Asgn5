using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class TargetSpawner : NetworkBehaviour
{
    public GameObject targetPrefab;
    public int numTargets;

    public override void OnStartServer()
    {
        for (int i=0; i < numTargets; i++)
        {
            var pos = new Vector3(
                Random.Range(-8.0f, 8.0f),
                0.2f,
                Random.Range(-8.0f, 8.0f)
                );

            var rotation = Quaternion.Euler( 0, 0, 0);

            var target = (GameObject)Instantiate(targetPrefab, pos, rotation);
            NetworkServer.Spawn(target);
        }
    }
}
