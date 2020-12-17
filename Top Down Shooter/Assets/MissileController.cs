using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileController : MonoBehaviour
{

    Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.back * 5.0f, ForceMode.Impulse);
        Invoke("LaunchMissile", 0.2f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void LaunchMissile()
    {
        rb.AddForce(Vector3.forward * 35.0f, ForceMode.Impulse);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

}
