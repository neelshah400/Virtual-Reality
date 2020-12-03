using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particles : MonoBehaviour
{

    public GameObject car;
    public ParticleSystem fireball;
    public ParticleSystem explosion;

    int presses;
    
    // Start is called before the first frame update
    void Start()
    {
        fireball.Stop();
        explosion.Stop();
        presses = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            presses++;
        if (presses == 1)
            fireball.Play();
        if (presses >= 2)
            explosion.Play();
    }

}
