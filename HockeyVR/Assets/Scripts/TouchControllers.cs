using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControllers : MonoBehaviour {

    public OVRInput.Controller controller;
	public GameObject puckSteve;
    private GameObject newPuck;
    
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (OVRInput.Get(OVRInput.Button.One, controller))
        {
            Debug.Log("Pressed A!");
            Destroy(newPuck);
            newPuck = Instantiate(puckSteve) as GameObject;
            newPuck.transform.position = new Vector3(10.369f, 2, 0);
        }
	}
}
