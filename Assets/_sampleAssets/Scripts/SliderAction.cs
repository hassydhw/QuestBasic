using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SliderAction : MonoBehaviour {

    public Text uText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnSliderValueChanged(float sValue)
    {
        uText.text = "value: " +   sValue.ToString("F2");
    }

}
