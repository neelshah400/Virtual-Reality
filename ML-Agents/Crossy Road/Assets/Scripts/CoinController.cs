using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{

    ChickenAgent agent;
    
    // Start is called before the first frame update
    void Start()
    {
        agent = transform.parent.parent.parent.GetChild(1).gameObject.GetComponent<ChickenAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Chicken")
        {
            agent.AddScore(1000);
            Destroy(gameObject);
        }
    }

}
