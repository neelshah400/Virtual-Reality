using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public GameObject world;
    
    // Start is called before the first frame update
    void Start()
    {
        (int dim, float gap, float bound) xConfig = (5, 150.0f, 0.0f);
        xConfig.bound = xConfig.dim * xConfig.gap;
        (int dim, float gap, float bound) zConfig = (5, 300.0f, 0.0f);
        zConfig.bound = zConfig.dim * zConfig.gap;
        for (float x = -xConfig.bound; x <= xConfig.bound; x += xConfig.gap)
        {
            for (float z = -zConfig.bound; z <= zConfig.bound; z += zConfig.gap)
            {
                Instantiate(world, new Vector3(x, 0, z), Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
