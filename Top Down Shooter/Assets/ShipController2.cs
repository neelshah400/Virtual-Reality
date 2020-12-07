using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController2 : MonoBehaviour
{

    float rPower;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rPower = Input.GetAxis("Horizontal") * Time.deltaTime * 100.0f;
        transform.Rotate(0, 0, -1.0f * rPower, Space.Self);
        Debug.Log(rPower);
    }

}
