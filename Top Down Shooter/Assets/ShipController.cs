using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{

    Collider col;
    Vector3 minPos, maxPos;
    float mPower;
    Quaternion rot, sRot, lRot, rRot;
    
    // Start is called before the first frame update
    void Start()
    {

        col = GetComponent<Collider>();

        sRot = transform.rotation;
        lRot = Quaternion.Euler(sRot.eulerAngles.x, sRot.eulerAngles.y, sRot.eulerAngles.z + 45.0f);
        rRot = Quaternion.Euler(sRot.eulerAngles.x, sRot.eulerAngles.y, sRot.eulerAngles.z - 45.0f);

    }

    // Update is called once per frame
    void Update()
    {

        minPos = Camera.main.WorldToScreenPoint(new Vector3(col.bounds.min.x, transform.position.y, transform.position.z));
        maxPos = Camera.main.WorldToScreenPoint(new Vector3(col.bounds.max.x, transform.position.y, transform.position.z));
        mPower = Input.GetAxis("Horizontal") * Time.deltaTime * 20.0f;
        if (minPos.x < 0 && mPower < 0 || maxPos.x > Screen.width && mPower > 0)
            mPower = 0;
        transform.Translate(Vector3.right * mPower, Space.World);

        if (Input.GetAxis("Horizontal") < 0.0f)
            rot = lRot;
        else if (Input.GetAxis("Horizontal") > 0.0f)
            rot = rRot;
        else
            rot = sRot;
        transform.rotation = Quaternion.Lerp(transform.rotation, rot, Time.deltaTime * 3.0f);

    }

}
