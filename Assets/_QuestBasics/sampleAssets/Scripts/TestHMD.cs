using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestHMD : MonoBehaviour
{
    TextMesh logMesh;
    OVRDisplay _ovrDisplay;

    // Use this for initialization
    void Start()
    {
        logMesh = GetComponent<TextMesh>();
        _ovrDisplay = OVRManager.display;
    }

    // Update is called once per frame
    void Update()
    {
        logMesh.text = _ovrDisplay.angularVelocity.ToString("F2"); // it works
        // logMesh.text = _ovrDisplay.angularAcceleration.ToString("F2");// it works
        // logMesh.text = _ovrDisplay.appFramerate.ToString("F0"); //it works 
    }
}