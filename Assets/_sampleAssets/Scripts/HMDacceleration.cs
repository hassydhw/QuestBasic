using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HMDacceleration : MonoBehaviour
{
    TextMesh logMesh;
    OVRDisplay _ovrDisplay;

    // Use this for initialization
    void Start()
    {
        logMesh = GetComponent<TextMesh>();
        _ovrDisplay = new OVRDisplay();
    }

    // Update is called once per frame
    void Update()
    {
        //logMesh.text = _ovrDisplay.acceleration.ToString("F2");// acceleration does not work ?
        //        logMesh.text = _ovrDisplay.angularVelocity.ToString("F2");// it works

        //        logMesh.text = OVRManager.display.angularAcceleration.ToString("F2");// it works
        logMesh.text = OVRManager.display.angularVelocity.ToString("F2");// it works




    }
}
