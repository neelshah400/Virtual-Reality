using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{

    Collider c;
    Vector3 minXScreenPos;
    Vector3 maxXScreenPos;
    float mPower;
    float rPower;
    
    // Start is called before the first frame update
    void Start()
    {
        c = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        minXScreenPos = Camera.main.WorldToScreenPoint(new Vector3(c.bounds.min.x, transform.position.y, transform.position.z));
        maxXScreenPos = Camera.main.WorldToScreenPoint(new Vector3(c.bounds.max.x, transform.position.y, transform.position.z));
        mPower = Input.GetAxis("Horizontal") * Time.deltaTime * 20.0f;
        rPower = (float)(Input.GetAxis("Horizontal") * -45.0 - transform.eulerAngles.z);
        if (minXScreenPos.x < 0 && mPower < 0 || maxXScreenPos.x > Screen.width && mPower > 0)
            mPower = 0;
        transform.Translate(Vector3.right * mPower);
        transform.Rotate(0, 0, rPower);
    }

}
