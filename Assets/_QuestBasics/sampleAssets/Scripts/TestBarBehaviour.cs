using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBarBehaviour : MonoBehaviour {

    AudioSource asourse;

	// Use this for initialization
	void Start () {
        asourse = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    private void OnTriggerEnter(Collider other)
    {
        asourse.Play();
    }




}
