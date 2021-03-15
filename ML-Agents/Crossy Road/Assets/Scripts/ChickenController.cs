using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenController : MonoBehaviour
{

    Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        float hInput = Input.GetAxis("Horizontal");
        float vInput = Input.GetAxis("Vertical");
        bool walk = hInput != 0.0f || vInput > 0.0f;
        animator.SetBool("Walk", walk);
        if (walk)
        {
            Vector3 angles = transform.rotation.eulerAngles;
            if (hInput < 0.0f)
                angles.y = 0.0f;
            else if (vInput > 0.0f)
                angles.y = 90.0f;
            else if (hInput > 0.0f)
                angles.y = 180.0f;
            transform.eulerAngles = angles;
            transform.Translate(Vector3.forward * 0.01f);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.collider.tag);
    }

}
