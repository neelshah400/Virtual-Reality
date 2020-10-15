using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    float rotationPower;
    Vector3 bottomPosition;

    // Start is called before the first frame update
    void Start()
    {
        bottomPosition = new Vector3(transform.position.x, GetComponent<Renderer>().bounds.min.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        rotationPower = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        transform.RotateAround(bottomPosition, new Vector3(0, 0, -1), rotationPower);
    }

}
