using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    Rigidbody rb;
    bool needsToJump;
    int numJumps = 0;
    
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
        if (numJumps == 0 && needsToJump)
        {
            rb.AddForce(Vector3.up * 300.0f);
            needsToJump = false;
            numJumps++;
        }
    }

}
