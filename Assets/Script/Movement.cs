using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Transform tf;
    // Start is called before the first frame update
    void Start()
    {
        tf = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            tf.position += new Vector3(0, 0, 3);
        } else if (Input.GetKeyDown(KeyCode.A))
        {
            tf.position += new Vector3(-3, 0, 0);
        } else if (Input.GetKeyDown(KeyCode.S))
        {
            tf.position += new Vector3(0, 0, -3);
        } else if (Input.GetKeyDown(KeyCode.D))
        {
            tf.position += new Vector3(3, 0, 0);
        }
    }
}
