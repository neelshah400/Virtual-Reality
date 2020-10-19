using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launch : MonoBehaviour
{

    Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        //transform.position = transform.position + (transform.right * 1.0f) + (transform.forward * 0.75f);
        transform.Translate(new Vector3(0, 0.15f, 0.65f), Space.Self);
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * 600.0f);
    }

    // Update is called once per frame
    void Update()
    {

    }

}
