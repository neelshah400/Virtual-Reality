using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSphereController : MonoBehaviour
{

    Renderer r;
    Light l;

    // Start is called before the first frame update
    void Start()
    {

        r = GetComponent<Renderer>();
        l = transform.GetChild(0).gameObject.GetComponent<Light>();

        Color color = Random.ColorHSV();
        r.material.SetColor("_Color", color);
        l.color = color;
        l.intensity = Random.Range(0.5f, 5.0f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        transform.localScale = Vector3.zero;
        Invoke("DestroySphere", 2.0f);
    }

    void DestroySphere()
    {
        Destroy(gameObject);
    }

}
