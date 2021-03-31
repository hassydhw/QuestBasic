using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;


//RecenterはQuestでは動作しない？

public class TestRecenter : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.RawButton.RIndexTrigger))
        {
            Debug.Log("right index " + Time.realtimeSinceStartup);
            OVRManager.display.RecenterPose();
        }

        // if (OVRInput.GetDown(OVRInput.RawButton.LIndexTrigger))
        // {
        //     Debug.Log("left index " + Time.realtimeSinceStartup);
        //     InputTracking.Recenter();// これはobsoleteされたっぽい
        // }
    }
}