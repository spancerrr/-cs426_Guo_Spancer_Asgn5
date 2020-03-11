
using UnityEngine;

public class birdsCollision : MonoBehaviour
{
    public AudioSource source;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        source.Play();
        Destroy(gameObject);
    }

}
