using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandTrackingSample : MonoBehaviour
{
    [SerializeField] TextMesh valueText;

    [SerializeField] OVRHand ovrHand;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        valueText.text = ovrHand.GetFingerPinchStrength(OVRHand.HandFinger.Thumb).ToString("F2");
    }
}