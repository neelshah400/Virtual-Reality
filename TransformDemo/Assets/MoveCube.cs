using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{

    float timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {

        // timer += 1;
        timer += Time.deltaTime;
        Debug.Log("Time passed: " + timer);

        transform.Translate(Vector3.forward);
        Debug.Log("z: " + transform.position.z);

    }

}
