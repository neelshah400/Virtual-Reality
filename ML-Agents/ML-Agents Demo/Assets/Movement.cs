using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.MLAgents;

public class Movement : Agent
{

    public override void OnActionReceived(float[] vectorAction)
    {
        for (int i = 0; i < vectorAction.Length; i++)
        {
            Debug.Log("Number: " + vectorAction[i] + " Position " + i);
        }
        transform.Translate(new Vector3(vectorAction[0], 0, vectorAction[1]) * Time.deltaTime);
    }

}
