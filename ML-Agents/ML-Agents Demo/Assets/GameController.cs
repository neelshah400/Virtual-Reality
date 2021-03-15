using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public GameObject prefab;
    
    // Start is called before the first frame update
    void Start()
    {
        for (float x = 0.0f; x <= 600.0f; x += 60.0f)
        {
            for (float z = 0.0f; z <= 600.0f; z += 60.0f)
            {
                Instantiate(prefab, new Vector3(x, 0, z), Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
