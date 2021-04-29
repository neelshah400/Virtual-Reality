using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{

    Renderer rend;
    Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rend = transform.GetChild(0).GetComponent<Renderer>();
        rend.material.color = Random.ColorHSV();
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * 400.0f);
    }

    // Update is called once per frame
    void Update()
    {
        float z = transform.localPosition.z;
        if (z < -22.0f || z > 22.0f)
            Destroy(gameObject);
    }

}
