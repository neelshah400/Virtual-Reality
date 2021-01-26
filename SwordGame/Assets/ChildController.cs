using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildController : MonoBehaviour
{

    Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.parent = null;
        rb = GetComponent<Rigidbody2D>();
        if (rb == null)
            rb = gameObject.AddComponent<Rigidbody2D>();
        rb.gravityScale = 1.0f;
        rb.AddForce(Random.insideUnitCircle.normalized * 5.0f, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

}
