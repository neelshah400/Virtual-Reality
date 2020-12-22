using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public GameObject prefab;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnLightSphere", 0.0f, 0.4f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnLightSphere()
    {
        float x = Random.Range(-4.0f, 4.0f);
        float z = Random.Range(-4.0f, 4.0f);
        Instantiate(prefab, new Vector3(x, 10.0f, z), Quaternion.identity);
    }

}
