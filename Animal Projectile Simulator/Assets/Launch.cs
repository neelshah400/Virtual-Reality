﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launch : MonoBehaviour
{

    Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.Translate(new Vector3(0, 0.15f, 0.65f), Space.Self);
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * 20.0f, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {

    }

}
