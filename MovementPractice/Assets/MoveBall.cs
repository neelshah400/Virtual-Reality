using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
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
        timer += Time.deltaTime;
        transform.Translate(Vector3.forward * Time.deltaTime);
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.up * Time.deltaTime);
        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(Vector3.down * Time.deltaTime);
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(Vector3.left * Time.deltaTime);
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Translate(Vector3.right * Time.deltaTime);
    }

}
