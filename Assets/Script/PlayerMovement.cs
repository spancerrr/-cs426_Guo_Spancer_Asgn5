using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerMovement : NetworkBehaviour
{
    /*
    public override void OnStartLocalPlayer()
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
    }
    */

    public float speed = 5.0f;
    public float rotationSpeed = 10;
    public float force = 50f;
    public GameObject cannon;
    public GameObject bullet;
    public AudioSource fire;

    Rigidbody rb;
    Transform t;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        t = GetComponent<Transform>();
    }
    [Command]
    void CmdFire(){
        GameObject newBullet = Instantiate(bullet, cannon.transform.position, cannon.transform.rotation) as GameObject;
        newBullet.GetComponent<Rigidbody>().velocity += Vector3.up * 10;
        newBullet.GetComponent<Rigidbody>().AddForce(newBullet.transform.forward * 1500);
        NetworkServer.Spawn(newBullet);
        Destroy(newBullet, 2.0f);
    }
    // Update is called once per frame
    void Update()
    {
        if (!isLocalPlayer){
            gameObject.GetComponent<Camera>().enabled = false;
            return;
        }
        else{
            if (Input.GetKey(KeyCode.W))
                rb.velocity += this.transform.forward * speed * Time.deltaTime;
            else if (Input.GetKey(KeyCode.S))
                rb.velocity -= this.transform.forward * speed * Time.deltaTime;

            if (Input.GetKey(KeyCode.D))
                t.rotation *= Quaternion.Euler(0, rotationSpeed * Time.deltaTime, 0);
            else if (Input.GetKey(KeyCode.A))
                t.rotation *= Quaternion.Euler(0, - rotationSpeed * Time.deltaTime, 0);

            if (Input.GetKeyDown(KeyCode.Space))
                rb.AddForce(t.up * force);

            if (Input.GetButtonDown("Fire1"))
            {
                CmdFire();
                fire.Play();
            //     GameObject newBullet = Instantiate(bullet, transform.position, transform.rotation) as GameObject;
            //     newBullet.GetComponent<Rigidbody>().velocity += Vector3.up * 10;
            // newBullet.GetComponent<Rigidbody>().AddForce(newBullet.transform.forward * 1500);
                }
        }

    }
}
