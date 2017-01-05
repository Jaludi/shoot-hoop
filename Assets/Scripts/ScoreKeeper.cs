using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour {
    int Score;
	// Use this for initialization
	void Start () {
        Score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void IncrementScore(int points)
    {
        Score+=points;
        print("Score: " + Score);
    }
}
