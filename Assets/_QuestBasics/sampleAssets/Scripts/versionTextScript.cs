using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QuestBasics;

public class versionTextScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var myTextMesh = GetComponent<TextMesh>();
        myTextMesh.text = myTextMesh.text + "\n" + ConfigSettings.versionNumber;
    }

    // Update is called once per frame
    void Update()
    {
    }
}