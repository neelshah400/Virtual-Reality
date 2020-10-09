using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    float movePower;
    bool needsToJump = false;
    Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        movePower = Input.GetAxis("Horizontal");
        if (Input.GetKeyDown(KeyCode.Space))
            needsToJump = true;
    }

    private void FixedUpdate()
    {
        rb.AddForce(Vector3.right * movePower * 5.0f);
        if (needsToJump)
        {
            rb.AddForce(Vector3.up * 200.0f);
            needsToJump = false;
        }
    }

}
