using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControllers : MonoBehaviour {

    public OVRInput.Controller controller;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (OVRInput.Get(OVRInput.Button.One, controller))
        {
            Debug.Log("Pressed A!");
        }
	}
}
