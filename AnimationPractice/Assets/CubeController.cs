using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{

    private Animation a;

    // Start is called before the first frame update
    void Start()
    {
        a = GetComponent<Animation>();
        a["SpinCube"].speed = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (a != null)
            {
                a.Play("SpinCube");
            }
        }
    }

}
