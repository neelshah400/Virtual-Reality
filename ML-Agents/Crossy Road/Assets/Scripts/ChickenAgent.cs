using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Sensors;
using TMPro;

public class ChickenAgent : Agent
{

    Transform roadAreaController;
    public GameObject car;
    float[] carX;
    public GameObject tree;
    float[] treeX;
    List<GameObject> trees;
    public GameObject coin;
    List<GameObject> coins;

    bool canScore;
    int score;
    public TMP_Text[] texts;
    Vector3 origLocalPos;
    Quaternion origLocalRot;
    Rigidbody rb;
    Animator animator;

    public override void Initialize()
    {

        base.Initialize();

        roadAreaController = transform.parent.GetChild(0).GetChild(0);

        carX = new float[] { -2.5f, -0.5f, 1.5f, 7.5f, 9.5f, 11.5f };
        treeX = new float[] { 4.0f, 14.0f };

        for (int i = 0; i < carX.Length; i++)
        {
            float delay = Random.Range(0.0f, 4.0f);
            float repeatRate = Random.Range(4.0f, 8.0f);
            StartCoroutine(GenerateCarRepeat(i, delay, repeatRate));
        }

        trees = new List<GameObject>();
        coins = new List<GameObject>();

        origLocalPos = transform.localPosition;
        origLocalRot = transform.localRotation;
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();

    }

    void GenerateCar(int i)
    {
        float z = i % 2 == 0 ? -22.0f : 22.0f;
        Vector3 pos = roadAreaController.position + new Vector3(carX[i], 0.0f, z);
        Quaternion rot = Quaternion.Euler(0.0f, i % 2 == 0 ? 0.0f : 180.0f, 0.0f);
        GameObject clone = Instantiate(car, pos, rot);
        clone.transform.parent = roadAreaController;
    }

    IEnumerator GenerateCarRepeat(int lane, float delay, float repeatRate)
    {
        yield return new WaitForSeconds(delay);
        while (true)
        {
            GenerateCar(lane);
            yield return new WaitForSeconds(repeatRate);
        }
    }

    public override void OnEpisodeBegin()
    {

        foreach (GameObject tree in trees)
            Destroy(tree);
        foreach (GameObject coin in coins)
            Destroy(coin);

        trees.Clear();
        for (int i = 0; i < treeX.Length; i++)
        {
            int numTrees = Random.Range(4, 9);
            for (int j = 0; j < numTrees; j++)
            {
                float z = Random.Range(-18.0f, 18.0f);
                Vector3 pos = roadAreaController.position + new Vector3(treeX[i], 0.0f, z);
                Quaternion rot = Quaternion.Euler(0.0f, Random.Range(0.0f, 360.0f), 0.0f);
                trees.Add(Instantiate(tree, pos, rot));
                trees[j].transform.parent = roadAreaController;
            }
        }

        coins.Clear();
        int numCoins = Random.Range(10, 12);
        for (int i = 0; i < numCoins; i++)
        {
            float x = carX[Random.Range(0, carX.Length)];
            float z = Random.Range(-18.0f, 18.0f);
            Vector3 pos = roadAreaController.position + new Vector3(x, 0.0f, z);
            coins.Add(Instantiate(coin, pos, Quaternion.identity));
            coins[i].transform.parent = roadAreaController;
        }

        canScore = true;
        score = 1000;
        transform.localPosition = origLocalPos;
        transform.localRotation = origLocalRot;
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;

    }

    public override void Heuristic(float[] actionsOut)
    {
        float hInput = Input.GetAxis("Horizontal");
        float vInput = Input.GetAxis("Vertical");
        if (hInput == 0.0f && vInput == 0.0f)
            actionsOut[0] = 3; // idle
        else if (vInput > 0.0f)
            actionsOut[0] = 0; // up
        else if (hInput < 0.0f)
            actionsOut[0] = 1; // left
        else if (hInput > 0.0f)
            actionsOut[0] = 2; // right
    }

    public override void OnActionReceived(float[] vectorAction)
    {
        AddScore(-1);
        if (!canScore)
            AddScore(-1000);
        float hInput = 0.0f;
        float vInput = 0.0f;
        if (vectorAction[0] == 0) // up
        {
            vInput = 1.00f;
            AddScore(10);
        }
        else if (vectorAction[0] == 1) // left
            hInput = -1.00f;
        else if (vectorAction[0] == 2) // right
            hInput = 1.00f;
        bool walk = hInput != 0.0f || vInput > 0.0f;
        animator.SetBool("Walk", walk);
        if (walk)
        {
            Vector3 angles = transform.rotation.eulerAngles;
            if (hInput < 0.0f)
                angles.y = 0.0f;
            else if (vInput > 0.0f)
                angles.y = 90.0f;
            else if (hInput > 0.0f)
                angles.y = 180.0f;
            transform.eulerAngles = angles;
            transform.Translate(Vector3.forward * 0.05f);
        }
    }

    public override void CollectObservations(VectorSensor sensor)
    {
        sensor.AddObservation(transform.localPosition);
        sensor.AddObservation(transform.localRotation);
    }

    private void OnCollisionEnter(Collision collision)
    {
        string tag = collision.collider.tag;
        if (tag == "Car")
        {
            SetReward(-1000);
            EndEpisode();
        }
        else if (tag == "Tree")
        {
            canScore = false;
            AddScore(-1000);
            transform.Translate(Vector3.back * 0.05f);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        string tag = collision.collider.tag;
        if (tag == "Tree")
            canScore = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Goal")
        {
            EndEpisode();
        }
    }

    public void AddScore(int scoreChange)
    {
        if (scoreChange <= 0 || (scoreChange > 0 && canScore))
        {
            score += scoreChange;
            foreach (TMP_Text t in texts)
            {
                if (t != null)
                    t.text = "" + score;
            }
            SetReward(score);
            if (score < 0)
                EndEpisode();
        }
    }

}
