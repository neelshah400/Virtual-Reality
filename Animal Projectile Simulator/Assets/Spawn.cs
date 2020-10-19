using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Quaternion rot = transform.rotation * Quaternion.Euler(Vector3.right * 90.0f) * Quaternion.Euler(Vector3.up * 90.0f);
            Instantiate(prefab, transform.position, rot);
        }
    }

}
