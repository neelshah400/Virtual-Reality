using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public ParticleSystem explosion;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!explosion.IsAlive())
            transform.Translate(Vector3.forward * Time.deltaTime * 20.0f, Space.Self);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.other.gameObject.name.Contains("Missile"))
        {
            Destroy(collision.transform.gameObject);
            transform.localScale = Vector3.zero;
            explosion.Play();
            Invoke("DestroyEnemy", 2.0f);
        }
    }

    void DestroyEnemy()
    {
        Destroy(gameObject);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

}
