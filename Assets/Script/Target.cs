using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Target : MonoBehaviour
{

    //public Score scoreManager;

    private void OnCollisionEnter(Collision collision) {
        var hit = collision.gameObject;
        var hitTarget = hit.GetComponent<PlayerMovement>();
        if (hitTarget != null)
        {
            var inventory = hit.GetComponent<TargetInventory>();
            inventory.CollectTarget(1);
            Destroy(gameObject);
        }
    }
}
