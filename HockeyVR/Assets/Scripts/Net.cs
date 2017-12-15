using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Net : MonoBehaviour {

    public Scoreboard scoreboard;
    private int score;
    private bool isColliding;
	// Use this for initialization
	void Start () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "puck")
        {
            if (isColliding) return;
            isColliding = true;
            score++;
            scoreboard.homeScore.text = "" +score;
            Debug.Log("found puck"); 
        }
        Debug.Log("found... something?");
    }

    private void OnTriggerExit(Collider other)
    {
        isColliding = false;
    }
    // Update is called once per frame
    void Update () {
		
	}
}
