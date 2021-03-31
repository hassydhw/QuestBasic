using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class versionTextScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var myTextMesh = GetComponent<TextMesh>();
        myTextMesh.text = myTextMesh.text + "\n" + QB_ConfigSettings.versionNumber;
    }
}