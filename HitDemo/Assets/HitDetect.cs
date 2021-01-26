using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitDetect : MonoBehaviour
{

    public LayerMask layer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Collider2D[] stuffHit;
            stuffHit = Physics2D.OverlapCircleAll(transform.position, 5, layer);
            for (int i = 0; i < stuffHit.Length; i++)
                Debug.Log(stuffHit[i].gameObject.name);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, 5);
    }

}
