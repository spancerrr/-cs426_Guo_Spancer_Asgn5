using UnityEngine;
using UnityEngine.Networking;

public class LookAtbird : NetworkBehaviour
{
    private GameObject cameraToLookAt = null;
    private GameObject[] respawns;
   

    void Update()
    {
        if (cameraToLookAt == null)
        {
            //cameraToLookAt = GameObject.Find("playerBird(Clone)") as GameObject;
            respawns = GameObject.FindGameObjectsWithTag("bird");
            if (respawns == null)
            {
                Debug.Log("null");
            }
            else {
                Debug.Log(respawns.Length);
                cameraToLookAt = respawns[0];
                this.transform.rotation = cameraToLookAt.transform.rotation;

            }
            //Debug.Log(cameraToLookAt.transform.position);
        }
        else
        {
            this.transform.rotation = cameraToLookAt.transform.rotation;
        }
    }
}