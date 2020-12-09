using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{

    Renderer rend;
    Vector3 minPos, maxPos;

    float mPower;
    Quaternion rot, sRot, lRot, rRot;

    public GameObject missile;

    Vector3 lMisslePos, rMissilePos;
    
    // Start is called before the first frame update
    void Start()
    {

        rend = GetComponent<Renderer>();

        sRot = transform.rotation;
        lRot = Quaternion.Euler(sRot.eulerAngles.x, sRot.eulerAngles.y, sRot.eulerAngles.z + 45.0f);
        rRot = Quaternion.Euler(sRot.eulerAngles.x, sRot.eulerAngles.y, sRot.eulerAngles.z - 45.0f);

        lMisslePos = new Vector3(-3.5f, 0.0f, -10.0f);
        rMissilePos = new Vector3();

    }

    // Update is called once per frame
    void Update()
    {

        minPos = Camera.main.WorldToScreenPoint(new Vector3(rend.bounds.min.x, transform.position.y, transform.position.z));
        maxPos = Camera.main.WorldToScreenPoint(new Vector3(rend.bounds.max.x, transform.position.y, transform.position.z));
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
        transform.rotation = Quaternion.Slerp(transform.rotation, rot, Time.deltaTime * 3.0f);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Shoot missile");
            Instantiate(missile, lMisslePos, Quaternion.identity);
        }

    }

}
