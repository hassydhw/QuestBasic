using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerRotation : MonoBehaviour
{

    public TextMesh rotationMesh;

    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        //OVRInput.Controller activeController = OVRInput.GetActiveController();
        //Quaternion rot = OVRInput.GetLocalControllerRotation(activeController);

        Quaternion rot = OVRInput.GetLocalControllerRotation(OVRInput.Controller.LTouch);

        transform.rotation = rot;
        rotationMesh.text = rot.eulerAngles.ToString();

    }
}
