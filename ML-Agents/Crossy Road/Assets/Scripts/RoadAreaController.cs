using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadAreaController : MonoBehaviour
{

    public GameObject car;
    float[] carX;

    public GameObject tree;
    float[] treeX;

    
    // Start is called before the first frame update
    void Start()
    {

        carX = new float[] { -2.5f, -0.5f, 1.5f, 7.5f, 9.5f, 11.5f };
        for (int i = 0; i < carX.Length; i++)
        {
            float z = Random.Range(-18.0f, 18.0f);
            Vector3 pos = new Vector3(carX[i], 0.0f, z);
            Quaternion rot = Quaternion.Euler(0.0f, i % 2 == 0 ? 0.0f : 180.0f, 0.0f);
            Instantiate(car, pos, rot);
        }

        treeX = new float[] { 4.0f, 14.0f };
        for (int i = 0; i < treeX.Length; i++)
        {
            int numTrees = Random.Range(6, 18);
            for (int j = 0; j < numTrees; j++)
            {
                float z = Random.Range(-18.0f, 18.0f);
                Vector3 pos = new Vector3(treeX[i], 0.0f, z);
                Quaternion rot = Quaternion.Euler(0.0f, Random.Range(0.0f, 360.0f), 0.0f);
                Instantiate(tree, pos, rot);
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
