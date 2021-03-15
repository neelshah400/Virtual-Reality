using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeController : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale *= Random.Range(0.2f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
