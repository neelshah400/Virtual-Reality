using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    float forceAmount;
    float movePower;
    Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        forceAmount = 4.0f;
        // movePower = 0;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Speed of Ball: " + rb.velocity.z);
        movePower = Input.GetAxis("Horizontal");
        Debug.Log("Horizontal Move Power: " + movePower);
    }

    private void FixedUpdate()
    {
        // rb.AddForce(new Vector3(0, 0, 1));
        // rb.AddForce(Vector3.forward * forceAmount);
        // rb.AddForce(Vector3.forward * forceAmount, ForceMode.Impulse);
    }

}
