using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hatCheck : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
         if (!this.transform.parent.GetComponent<PlayerMovement>().isLocalPlayer)
         {
             this.gameObject.SetActive(false);
         }
    }
}
