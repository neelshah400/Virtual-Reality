using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabController : MonoBehaviour
{

    GameController gameController;
    ParticleSystem childParticleSystem;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        gameController = GameObject.Find("GameController").GetComponent<GameController>();
        childParticleSystem = transform.GetChild(0).gameObject.GetComponent<ParticleSystem>();
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.down * 7.0f, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        if (!childParticleSystem.IsAlive())
            Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        gameController.IncreaseScore();
        transform.localScale = Vector3.zero;
        childParticleSystem.Stop();
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

}
