using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerAcceleration : MonoBehaviour
{

    public TextMesh AccelerationMesh;

    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        //OVRInput.Controller activeController = OVRInput.GetActiveController();
        //Vector3 acc = OVRInput.GetLocalControllerAcceleration(activeController);

        Vector3 acc = OVRInput.GetLocalControllerAcceleration(OVRInput.Controller.RTouch);

        transform.localScale = Vector3.one * (acc.magnitude / 10 + 0.1f);
        AccelerationMesh.text = acc.ToString();
    }
}
