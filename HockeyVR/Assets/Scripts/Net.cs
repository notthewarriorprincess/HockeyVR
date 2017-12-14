using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Net : MonoBehaviour {

    public Scoreboard scoreboard;
	// Use this for initialization
	void Start () {
		
	}

    void OnCollisionEnter(Collision collider)
    {
        if (collider.gameObject.name == "Puck2")
        {
            scoreboard.homeScore.text += 1;
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
