using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public GameObject prefab;
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            Instantiate(prefab, new Vector3(0.0f, i * 1.5f, 0.0f), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
