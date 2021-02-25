using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Sensors;

public class Movement : Agent
{

    public Transform food;
    int count;

    public override void OnEpisodeBegin()
    {

        count = 1000;

        Transform[] items = new Transform[] { transform, food };
        foreach (Transform item in items)
        {
            item.localPosition = GetRandomVector(6.0f);
            item.GetComponent<Rigidbody>().freezeRotation = true;
            item.GetComponent<Rigidbody>().velocity = Vector3.zero;
        }

    }

    public Vector3 GetRandomVector(float d)
    {
        float x = Random.Range(-d, d);
        float y = 0.5f;
        float z = Random.Range(-d, d);
        return new Vector3(x, y, z);
    }

    public override void OnActionReceived(float[] vectorAction)
    {
        AddReward(-0.0005f);
        count--;
        if (count <= 0)
        {
            AddReward(-0.5f);
            EndEpisode();
        }
        transform.Translate(new Vector3(vectorAction[0], 0, vectorAction[1]) * Time.deltaTime * 3.0f);
    }

    public override void CollectObservations(VectorSensor sensor)
    {
        sensor.AddObservation(transform.localPosition);
        sensor.AddObservation(food.transform.localPosition);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (count == 1000)
            EndEpisode();
        Debug.Log("Hit (count = " + count + ")");
        AddReward(1.0f);
        EndEpisode();
    }

}
