using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public OVRInput.Controller controller;
    public GameObject playerStick;
    public GameObject puckSteve;
    private GameObject newPuck;
    // Use this for initialization
    void Start () {
        newPuck = Instantiate(puckSteve) as GameObject;
        newPuck.transform.position = new Vector3(10.369f, 2, 0);
    }
	
	// Update is called once per frame
	void Update () {
        if (newPuck.transform.position.y < -1 || OVRInput.Get(OVRInput.Button.One, controller))
        {
            //Debug.Log("I FELL!");
            Destroy(newPuck);
            newPuck = Instantiate(puckSteve) as GameObject;
            newPuck.transform.position = new Vector3(10.369f, 2, 0);
        }

        if (OVRInput.Get(OVRInput.Button.Three, controller))
        {
            playerStick.transform.position = new Vector3(10.25f, 1.34f, 0.16f);
        }
    }
}
