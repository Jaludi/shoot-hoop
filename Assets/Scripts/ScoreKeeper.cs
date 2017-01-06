using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour {
    public int Score;
    public int shots;

	// Use this for initialization
	void Start () {
        Score = 0;
        shots = 0;
        DontDestroyOnLoad(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void IncrementScore(int points)
    {
        Score+=points;
        
    }
}
