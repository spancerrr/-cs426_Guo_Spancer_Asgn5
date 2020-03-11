using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextDestory : MonoBehaviour
{
    int Seconds = 5;
      void Start()
      {
      }

      // Update is called once per frame
      void Update()
      {
         Destroy();
      }
    
      void Destroy(){
          Destroy(gameObject,Seconds);
      }
}
