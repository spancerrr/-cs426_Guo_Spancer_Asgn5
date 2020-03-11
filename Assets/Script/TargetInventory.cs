using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class TargetInventory : NetworkBehaviour
{
    public const int score = 6;
    public AudioSource eat;
    [SyncVar]
    public int collectedTarget = 0;

    public void CollectTarget(int amount)
    {
        eat.Play();
        if (!isServer)
            return;

        collectedTarget= collectedTarget + amount;
        if (collectedTarget >= score)
        {
             Debug.Log("You won!");
             RpcRespawn();
        }
    }

    [ClientRpc]
    void RpcRespawn()
    {
        if (isLocalPlayer)
        {
            // move back to zero location
            gameObject.GetComponent<Text>().text = "You won!";
        }
    }
}
