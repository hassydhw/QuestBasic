using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonAction : MonoBehaviour
{
    // [SerializeField] Image image;
    public Text buttonText;

    public void OnClick()
    {
        buttonText.text = "clicked at" + Time.realtimeSinceStartup.ToString("f2");
    }
}