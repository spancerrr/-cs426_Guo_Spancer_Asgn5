 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;

 public class cameraController : MonoBehaviour
 {

     // Update is called once per frame
     void Update()
     {
          if (!this.transform.parent.GetComponent<PlayerMovement>().isLocalPlayer)
          {
              gameObject.GetComponent<Camera>().enabled = false;
              gameObject.GetComponent<AudioListener>().enabled = false;
          }
     }
 }
