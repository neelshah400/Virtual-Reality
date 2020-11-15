using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public Transform player;
    public GameObject prefab;
    public Text text;

    int score;

    float hPower;
    float vPower;

    float spawnTime;
    float elapsedTime;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        StartSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        hPower = Input.GetAxis("Horizontal") * Time.deltaTime * 10.0f;
        vPower = Input.GetAxis("Vertical") * Time.deltaTime * 10.0f;
        player.Translate(new Vector3(hPower, 0, vPower));
        CheckSpawn();
    }

    public void IncreaseScore()
    {
        score++;
        text.text = "Score: " + score;
    }

    void StartSpawn()
    {
        spawnTime = Random.Range(1.0f, 3.0f);
        elapsedTime = 0.0f;
    }

    void CheckSpawn()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime >= spawnTime)
        {
            Instantiate(prefab, new Vector3(Random.Range(-8.0f, 8.0f), 20.0f, Random.Range(-14.0f, -6.0f)), Quaternion.identity);
            StartSpawn();
        }
    }

}
