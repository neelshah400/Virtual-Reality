using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{

    public Rigidbody ship;
    public ParticleSystem center;
    public ParticleSystem left;
    public ParticleSystem right;

    public bool started;
    
    // Start is called before the first frame update
    void Start()
    {
        center.Stop();
        left.Stop();
        right.Stop();
        started = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!started && Input.GetKeyDown(KeyCode.Space))
        {
            ship.AddForce(Vector3.forward * 100.0f);
            center.Play();
            left.Play();
            right.Play();
            started = true;
        }
    }

}
