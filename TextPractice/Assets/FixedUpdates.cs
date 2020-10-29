using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FixedUpdates : MonoBehaviour
{
    
    Text text;
    int count;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        count++;
        text.text = "Fixed Updates: " + count;
    }

}
