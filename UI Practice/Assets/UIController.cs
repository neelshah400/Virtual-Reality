using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{

    public Button buttonClockwise;
    public Button buttonCounterclockwise;
    public Text textRotation;
    public Transform cube;
    
    // Start is called before the first frame update
    void Start()
    {
        UpdateText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RotateClockwise()
    {
        cube.Rotate(0, 0, -1);
        UpdateText();
    }

    public void RotateCounterclockwise()
    {
        cube.Rotate(0, 0, 1);
        UpdateText();
    }

    public void UpdateText()
    {
        textRotation.text = Math.Round(cube.rotation.eulerAngles.z) + " Degrees";
    }

}
