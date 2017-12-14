using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoreboard : MonoBehaviour {

    public Text homeScore;
    [SerializeField]
    private Text timeText;

    private bool gameOn = true;
	// Use this for initialization
	void Start () {
        StartCoroutine("updateTime");
    }

    IEnumerator updateTime()
    {
        while (gameOn)
        {
            var today = System.DateTime.Now;
            timeText.text = today.ToString("HH:mm");
            yield return new WaitForSeconds(5);
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
