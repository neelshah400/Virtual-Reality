using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    Rigidbody rb;
    bool needsToJump;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            needsToJump = true;
    }

    private void FixedUpdate()
    {
        if (needsToJump)
        {
            rb.AddForce(Vector3.up * 300.0f);
            needsToJump = false;
        }
    }

}
